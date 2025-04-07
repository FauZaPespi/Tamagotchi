using P_Tamagotchi.Game;
using P_Tamagotchi.Resources;
using P_Tamagotchi.Utils;
using System;
using SQLitePCL; // Ajoute ce using
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace P_Tamagotchi
{
    public partial class FrmTamagotchi : Form
    {
        private DbConnection dbConnection = DbConnection.GetInstance();
        private int nbTick = 0;

        public FrmTamagotchi()
        {
            InitializeComponent();
            GameManager.GetInstance().AddTamagotchis(new Tamagotchi("Test", new Sprite(10, 0)));
            pictureTamagotchi.Image = GameManager.GetInstance().GetTamagotchis()[0].Sprite.GetSprite();
            using (var reader = dbConnection.Query("SELECT * FROM main"))
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write($"{reader.GetName(i)}: {reader.GetValue(i)} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private void FrmTamagotchi_Load(object sender, EventArgs e)
        {
            tmTick.Interval = GameManager.GetInstance().TickRate;
            btnLeft.Parent = pnlController;
            btnMid.Parent = pnlController;
            btnRight.Parent = pnlController;
        }

        private void tmTick_Tick(object sender, EventArgs e)
        {
            nbTick++;
            GameManager.GetInstance().Update(nbTick);
            lsbTamagotchis.DataSource = GameManager.GetInstance().GetTamagotchis();
            lsbTamagotchis.ValueMember = "Nom";
            lsbTamagotchis.DisplayMember = "Nom";
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = GameManager.GetInstance().GetTamagotchis();
            lsbTamagotchis.DataSource = bindingSource;
            if (GameManager.GetInstance().GetTamagotchi() != null)
            {
                lblInfoTama.Text = GameManager.GetInstance().GetTamagotchi().ToString();
            } else
            {
                if (GameManager.GetInstance().GetTamagotchis().Count == 0)
                {
                    foreach (Button control in pnlController.Controls)
                    {
                        control.Hide();
                    }
                }
                else
                {
                    foreach (var control in pnlController.Controls)
                    {
                        Button btn = (Button)control;
                        btn.Show();
                    }
                }
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Tamagotchi tamagotchi = GameManager.GetInstance().GetTamagotchi();
            GameManager.GetInstance().Feed(tamagotchi, new Food("Poulet", "abc", 15));

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Tamagotchi tamagotchi = GameManager.GetInstance().GetTamagotchi();
            GameManager.GetInstance().Heal(tamagotchi, 10);
        }

        private void lsbTamagotchis_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameManager.GetInstance().SetCurrentIndex(lsbTamagotchis.SelectedIndex);
            Console.WriteLine(GameManager.GetInstance().GetTamagotchi());
        }

        private void chkFreeze_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFreeze.Checked)
            {
                tmTick.Enabled = !chkFreeze.Checked;
                tmTick.Stop();
            }
            else
            {
                tmTick.Enabled = !chkFreeze.Checked;
                tmTick.Start();

            }
        }

        private void upDownMulti_ValueChanged(object sender, EventArgs e)
        {
            tmTick.Interval = GameManager.GetInstance().TickRate / (int)upDownMulti.Value;
        }
    }

}
