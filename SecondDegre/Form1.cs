using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SecondDegre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //toolTip1.SetToolTip(this.textBox1, "(Test)");
            txtA.SetPlaceholder("a");
            txtB.SetPlaceholder("b");
            txtC.SetPlaceholder("c");

            tipAstuce.SetToolTip(lblAstuce, "En cliquant sur un résultat, l'élément cliqué sera automatiquement reporté dans le presse papier");
            tipAstuce.IsBalloon = true;

        }

        // Toutes les TextBox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            // Autorise les chiffres
            if (char.IsDigit(e.KeyChar))
                return;

            // Autorise les touches de contrôle (Backspace, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Autorise le signe moins uniquement au début
            if (e.KeyChar == '-' && tb.SelectionStart == 0 && !tb.Text.Contains('-'))
                return;

            // Autorise le séparateur décimal (une seule fois)
            if ((e.KeyChar == ',' || e.KeyChar == '.') && !tb.Text.Contains(','))
            {
                e.KeyChar = ',';
                return;
            }

            // Sinon, on bloque
            e.Handled = true;
        }


        // Input A -> txtEssaiA
        private void lblEssai_Click(object sender, EventArgs e)
        {
            txtEssaiA.Focus();
        }

        private void txtEssai_Enter(object sender, EventArgs e)
        {
            lblEssaiA.Visible = false;
        }

        private void txtEssai_Leave(object sender, EventArgs e)
        {
            if (txtEssaiA.Text.Length == 0)
            {
                lblEssaiA.Visible = true;
            }
        }


        // Input B -> txtEssaiB
        private void lblEssaiB_Click(object sender, EventArgs e)
        {
            txtEssaiB.Focus();
        }

        private void txtEssaiB_Enter(object sender, EventArgs e)
        {
            lblEssaiB.Visible = false;
        }

        private void txtEssaiB_Leave(object sender, EventArgs e)
        {
            if (txtEssaiB.Text.Length == 0)
            {
                lblEssaiB.Visible = true;
            }
        }


        // Input C -> txtEssaiC
        private void lblEssaiC_Click(object sender, EventArgs e)
        {
            txtEssaiC.Focus();
        }

        private void txtEssaiC_Enter(object sender, EventArgs e)
        {
            lblEssaiC.Visible = false;
        }

        private void txtEssaiC_Leave(object sender, EventArgs e)
        {
            if (txtEssaiC.Text.Length == 0)
            {
                lblEssaiC.Visible = true;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRaz_Click(object sender, EventArgs e)
        {
            // On supprime tout ce qui a pu être entré comme valeurs
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
            txtEssaiA.Text = string.Empty;
            txtEssaiB.Text = string.Empty;
            txtEssaiC.Text = string.Empty;

            // On désactive le groupe des résultats
            grpResultats.Enabled = false;

            // On active la visibilité des labels de nom des résultats
            lblX0.Visible = true;
            lblX1.Visible = true;
            lblX2.Visible = true;

            // On active la visibilité de tous les labels des résultats
            lblX0Resultat.Visible = true;
            lblX1Resultat.Visible = true;
            lblX2Resultat.Visible = true;

            // On remet les valeurs par défaut pour les labels des résultats
            lblX0Resultat.Text = "-b / 2a";
            lblX1Resultat.Text = "(-b -√∆) / 2a";
            lblX2Resultat.Text = "(-b +√∆) / 2a";

            // On remet les valeurs par défaut pour le résultat du delta et du nombre de solutions
            lblDeltaResultat.Text = "b² - 4ac";
            lblNbrSolutions.Text = "Nombre de solutions";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // On vérifie si au moins une des deux lignes de saisie a été entièrement complétée
            if ((
                    txtA.Text != string.Empty &&
                    txtB.Text != string.Empty && 
                    txtC.Text != string.Empty
                ) || (
                    txtEssaiA.Text != string.Empty &&
                    txtEssaiB.Text != string.Empty && 
                    txtEssaiC.Text != string.Empty
               ))
            {
                // On active le groupe des résultats
                grpResultats.Enabled = true;

                // On active la visibilité des labels de nom des résultats
                lblX0.Visible = true;
                lblX1.Visible = true;
                lblX2.Visible = true;

                // On active la visibilité de tous les labels des résultats
                lblX0Resultat.Visible = true;
                lblX1Resultat.Visible = true;
                lblX2Resultat.Visible = true;


                // On déclare nos 3 valeurs de texte utilisées plus tard
                string aText;
                string bText;
                string cText;

                // On détermine si on veut la première ligne d'input ou la deuxième
                if (txtA.Text != string.Empty)
                {
                    aText = txtA.Text;
                    bText = txtB.Text;
                    cText = txtC.Text;
                }
                else
                {
                    aText = txtEssaiA.Text;
                    bText = txtEssaiB.Text;
                    cText = txtEssaiC.Text;
                }

                // On vérifie que les valeurs entrées par l'utilisateur sont convertibles en double
                if (!double.TryParse(aText, out double a) ||
                    !double.TryParse(bText, out double b) ||
                    !double.TryParse(cText, out double c))
                {
                    MessageBox.Show("Valeurs numériques invalides");
                    grpResultats.Enabled = false;
                    return;
                }

                // On vérifie que a n'est pas nul
                // sinon, on redirige vers la saisie
                if (a == 0)
                {
                    MessageBox.Show("La valeur de a ne doit pas être nulle !");
                    grpResultats.Enabled = false;
                    if (txtA.Text != string.Empty)
                    {
                        txtA.Focus();
                    }
                    else
                    {
                        txtEssaiA.Focus();
                    }
                    return;
                }

                // On calcule delta
                double delta = (b * b) - (4 * a * c);

                // Puis on l'affiche
                lblDeltaResultat.Text = delta.ToString();

                if (delta > 0)
                {
                    lblNbrSolutions.Text = "∆ > 0, il existe deux racines réelles";

                    // On calcule la racine carrée de delta
                    double sqrtDelta = Math.Sqrt(delta);

                    // On calcule x1 et x2 en fonction de la racine carrée de delta
                    double x1 = (-b - sqrtDelta) / (2 * a);
                    double x2 = (-b + sqrtDelta) / (2 * a);

                    // On désactive les labels pour x0
                    lblX0.Visible = false;
                    lblX0Resultat.Visible = false;

                    // On affiche les valeurs pour x1 et x2
                    lblX1Resultat.Text = x1.ToString();
                    lblX2Resultat.Text = x2.ToString();
                }
                else if (delta == 0)
                {
                    lblNbrSolutions.Text = "∆ = 0, il existe une racine réelle";

                    double x0 = -b / (2*a);

                    // On désactive les labels pour x1
                    lblX1.Visible = false;
                    lblX1Resultat.Visible = false;

                    // On désactive les labels pour x2
                    lblX2.Visible = false;
                    lblX2Resultat.Visible = false;

                    // On affiche la valeur pour x0
                    lblX0Resultat.Text = x0.ToString();
                }
                else
                {
                    lblNbrSolutions.Text = "∆ < 0, il n'existe aucune racine réelle";

                    // On désactive les labels pour x1
                    lblX1.Visible = false;
                    lblX1Resultat.Visible = false;

                    // On désactive les labels pour x2
                    lblX2.Visible = false;
                    lblX2Resultat.Visible = false;

                    // On désactive le label de x0
                    lblX0.Visible = false;

                    lblX0Resultat.Text = "Essayez avec d'autres valeurs";
                }
                
            }
        }

        private void lblX0Resultat_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            try
            {
                Clipboard.SetText(lbl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de copier dans le presse-papiers");
            }
        }
    }
}



public static class TextBoxExtensions
{
    private const int EM_SETCUEBANNER = 0x1501;

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern Int32 SendMessage(
        IntPtr hWnd,
        int msg,
        int wParam,
        string lParam
    );

    public static void SetPlaceholder(this TextBox textBox, string text)
    {
        SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, text);
    }
}