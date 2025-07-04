using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMS_WF
{
    public partial class HistoryForm : Form
    {
        HistoryData[] _historyData;
        public HistoryForm(HistoryData[] historyData)
        {
            InitializeComponent();
            _historyData = historyData;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            if (_historyData.Length == 0) return;
            dgvHistory.Rows.Clear();
            for (int i = 0; i < _historyData.Length; i++)
            {
                dgvHistory.Rows.Add(_historyData[i].DateTime.ToString(), _historyData[i].Pressure, _historyData[i].Temperature);
            }
        }
    }
}
