using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticipationMO4
{
  public partial class LocalPhoneListForm : Form
  {
    public LocalPhoneListForm()
    {
      InitializeComponent();
    }

    private void localPhoneTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.localPhoneTableBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.localPhoneDbDataSet);

    }

    private void LocalPhoneListForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'localPhoneDbDataSet.LocalPhoneTable' table. You can move, or remove it, as needed.
      this.localPhoneTableTableAdapter.Fill(this.localPhoneDbDataSet.LocalPhoneTable);

    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
      this.localPhoneTableTableAdapter.FillByFN(this.localPhoneDbDataSet.LocalPhoneTable, TxtBoxFNSearch.Text);
    }
  }
}
