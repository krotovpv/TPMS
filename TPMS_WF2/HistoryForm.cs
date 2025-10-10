using System;
using System.Windows.Forms;

namespace TPMS_WF2
{
    public partial class HistoryForm : Form
    {
        string _number = "";
        HistoryData[] _historyData;
        public HistoryForm(string Number, HistoryData[] HistoryData)
        {
            InitializeComponent();
            _number = Number;
            this.Text = "Hystory " + _number;
            _historyData = HistoryData;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            if (_historyData.Length == 0) return;
            dgvHistory.Rows.Clear();
            for (int i = 0; i < _historyData.Length; i++)
            {
                if (_historyData[i].Number == _number)
                    dgvHistory.Rows.Add(_historyData[i].DateTime.ToString(), _historyData[i].Code, _historyData[i].Pressure, _historyData[i].Temperature);
            }
        }
    }
}
