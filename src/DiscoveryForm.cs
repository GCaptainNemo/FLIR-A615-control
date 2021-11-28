using System;
using System.Threading;
using System.Windows.Forms;
using Flir.Atlas.Live.Device;
using Flir.Atlas.Live.Discovery;

namespace ThermalImageStreamerDemo
{
    public partial class DiscoveryForm : Form
    {
        private Discovery _discovery;
        public DiscoveryForm()
        {
            InitializeComponent();
        }

        private void DiscoveryForm_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void DiscoveryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        private void listViewDevices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectCameraFromListCtrl();
            DialogResult = DialogResult.OK;
            Close();
        }

        void _discovery_DeviceError(object sender, DeviceErrorEventArgs e)
        {
            BeginInvoke((Action)(() => ShowError(e.ErrorMessage)));
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message);
        }

        void _discovery_DeviceLost(object sender, CameraDeviceInfoEventArgs e)
        {
            BeginInvoke((Action)(() => RemoveDevice(e.CameraDevice)));
        }

        void _discovery_DeviceFound(object sender, CameraDeviceInfoEventArgs e)
        {
            BeginInvoke((Action)(() => AddDevice(e.CameraDevice)));
        }

        private void RemoveDevice(CameraDeviceInfo cameraDeviceInfo)
        {
            foreach (ListViewItem item in listViewDevices.Items)
            {
                var device = item.Tag as CameraDeviceInfo;
                if (device != null && device.DeviceIdentifier == cameraDeviceInfo.DeviceIdentifier)
                {
                    listViewDevices.Items.Remove(item);
                }
            }
        }

        private void AddDevice(CameraDeviceInfo cameraDeviceInfo)
        {
            // A camera have been found, add the camera to the list control.
            // One camera might support multiple streaming formats, iterate and add...
            foreach (var streamingFormat in cameraDeviceInfo.StreamingFormats)
            {
                // This can be filtered if your only want 16-bit cameras or Video overlay.
                //if (streamingFormat != ImageFormat.FlirFileFormat)
                //{
                //    continue;
                //}

                var info = new CameraDeviceInfo(cameraDeviceInfo);
                var item = new ListViewItem(string.Format("{0}", cameraDeviceInfo.Name));
                if (cameraDeviceInfo.IpSettings != null)
                {
                    item.SubItems.Add(cameraDeviceInfo.IpSettings.IpAddress);
                    item.SubItems.Add(cameraDeviceInfo.IpSettings.IsWireless ? "Yes" : "No");
                }
                else
                {
                    item.SubItems.Add("N/A"); // IP
                    item.SubItems.Add("N/A"); // WiFi
                }
                
                info.SelectedStreamingFormat = streamingFormat;
                item.SubItems.Add(streamingFormat.ToString());
                item.Tag = info;
                listViewDevices.Items.Add(item);
            }

        }

        public CameraDeviceInfo SelectedCameraDevice { get; set; }

        static void DisposeDiscovery(Object context)
        {
            var discovery = (Discovery)context;
            discovery.Dispose();
        }

        private void Start()
        {
            Stop();
            _discovery = new Discovery();
            _discovery.DeviceFound += _discovery_DeviceFound;
            _discovery.DeviceLost += _discovery_DeviceLost;
            _discovery.DeviceError += _discovery_DeviceError;

            // Scan for camera devices on all interfaces. If you are only interested in devices from i.e. USB
            // then you can start Discovery with the bit-flag Interface.Usb.

            // _discovery.Start(Interface.Usb);
            
            // or with a combination
            // _discovery.Start(Interface.Network | Interface.Usb); 

            // Start discovery, scan on all interfaces. 
            // This requires that Bonjour and the Pleora drivers are installed, see the Atlas web page for more information.
            _discovery.Start();
        }

        private void Stop()
        {
            if (_discovery == null) return;
            _discovery.DeviceFound -= _discovery_DeviceFound;
            _discovery.DeviceLost -= _discovery_DeviceLost;
            _discovery.DeviceError -= _discovery_DeviceError;
            // Stop discovery might take some time. Put dispose of discovery on a background thread.
            ThreadPool.QueueUserWorkItem(DisposeDiscovery, _discovery);
            _discovery = null;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectCameraFromListCtrl();
            DialogResult = DialogResult.OK;
            Close();
        }

        void SelectCameraFromListCtrl()
        {
            var items = listViewDevices.SelectedItems;
            if (items.Count <= 0) return;
            var lv = items[0];
            var device = lv.Tag as CameraDeviceInfo;
            SelectedCameraDevice = device;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void listViewDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = listViewDevices.SelectedItems;
            buttonSelect.Enabled = items.Count != 0;
        }
    }
}
