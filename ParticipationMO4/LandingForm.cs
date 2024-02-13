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
  public partial class LandingForm : Form
  {
    public LandingForm()
    {
      InitializeComponent();
    }

    private void BtnLocalPhoneNums_Click(object sender, EventArgs e)
    {
      LocalPhoneListForm frm = new LocalPhoneListForm();
      frm.ShowDialog();
    }

    private void BtnImportedNums_Click(object sender, EventArgs e)
    {

    }

    private void BtnOnlineNums_Click(object sender, EventArgs e)
    {

    }

    private void BtnClose_Click(object sender, EventArgs e)
    {

    }
  }
}
