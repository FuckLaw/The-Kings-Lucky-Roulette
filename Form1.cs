using System;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Kings_Lucky_Roulette
{
    public partial class Form1 : Form
    {
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }


        public void mensagem_premio(int premio)
        {
            switch (premio)
            {
                case 0:
                    MessageBox.Show("Parabéns, você escolhe qualquer rifle, caso já tenha o prêmio pode trocar pelo valor do item (menor valor)!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 1:
                    MessageBox.Show("Parabéns, você pode escolher qualquer Veículo BMW!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 2:
                    MessageBox.Show("Parabéns, você pode escolher qualquer Moto Esportiva!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 3:
                    MessageBox.Show("Parabéns, você pode escolher qualquer Casa!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 4:
                    MessageBox.Show("Parabéns, você pode escolher qualquer Veículo Mercedes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 5:
                    MessageBox.Show("Parabéns, você obteve R$100,000!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 6:
                    MessageBox.Show("Parabéns, você pode escolher qualquer Moto Comum!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 7:
                    MessageBox.Show("Parabéns, você obteve VIP Ouro por 14 dias!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 8:
                    MessageBox.Show("Parabéns, você escolhe qualquer sniper, caso já tenha o prêmio pode trocar pelo valor do item (menor valor)!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 9:
                    MessageBox.Show("Infelizmente você não obteve prêmio, mais sorte na próxima vez!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 10:
                    MessageBox.Show("Parabéns, você escolhe qualquer rifle, caso já tenha o prêmio pode trocar pelo valor do item (menor valor)!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 11:
                    MessageBox.Show("Parabéns, você pode escolher qualquer Casa!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 12:
                    MessageBox.Show("Parabéns, você obteve VIP Ouro por 30 dias!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 13:
                    MessageBox.Show("Parabéns, você pode escolher qualquer Moto Comum!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 14:
                    MessageBox.Show("Parabéns, você obteve R$1,000,000!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 15:
                    MessageBox.Show("Parabéns, você pode escolher qualquer Veículo BMW!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 16:
                    MessageBox.Show("Infelizmente você não obteve prêmio, mais sorte na próxima vez!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 17:
                    MessageBox.Show("Parabéns, você pode escolher qualquer Veículo Mercedes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 18:
                    MessageBox.Show("Parabéns, você obteve VIP Ouro por 7 dias!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 19:
                    MessageBox.Show("Parabéns, você escolhe qualquer sniper, caso já tenha o prêmio pode trocar pelo valor do item (menor valor)!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 20:
                    MessageBox.Show("Parabéns, você pode escolher qualquer Moto Esportiva!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 21:
                    MessageBox.Show("Parabéns, você obteve R$1,000,000!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 22:
                    MessageBox.Show("Parabéns, você obteve VIP Ouro por 14 dias!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 23:
                    MessageBox.Show("Parabéns, você obteve VIP Ouro por 30 dias!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;


                case 24: // Sniper
                    MessageBox.Show("Parabéns, você escolhe qualquer sniper, caso já tenha o prêmio pode trocar pelo valor do item (menor valor)!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 25: // Mercedez
                    MessageBox.Show("Parabéns, você pode escolher qualquer Veículo Mercedes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 26: // Nada
                    MessageBox.Show("Infelizmente você não obteve prêmio, mais sorte na próxima vez!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 27: // Bmw
                    MessageBox.Show("Parabéns, você pode escolher qualquer Veículo BMW!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 28: // Dinheiro máximo
                    MessageBox.Show("Parabéns, você obteve R$1,000,000!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 29: // Vip 1 mês
                    MessageBox.Show("Parabéns, você obteve VIP Ouro por 30 dias!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 30: // Vip 14 dias
                    MessageBox.Show("Parabéns, você obteve VIP Ouro por 14 dias!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 31: // Dinheiro máximo
                    MessageBox.Show("Parabéns, você obteve R$1,000,000!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 32: // MotoBoa
                    MessageBox.Show("Parabéns, você pode escolher qualquer Moto Esportiva!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;


                case 33: //Dinheiro minimo
                    MessageBox.Show("Parabéns, você obteve R$100,000!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 34: // Mercedes
                    MessageBox.Show("Parabéns, você pode escolher qualquer Veículo Mercedes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 35: // Casa
                    MessageBox.Show("Parabéns, você pode escolher qualquer Casa!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 36: // Moto Ruim
                    MessageBox.Show("Parabéns, você pode escolher qualquer Moto Comum!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 37: // Vip 30 Dias
                    MessageBox.Show("Parabéns, você obteve VIP Ouro por 30 dias!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 38: // Rifle
                    MessageBox.Show("Parabéns, você escolhe qualquer rifle, caso já tenha o prêmio pode trocar pelo valor do item (menor valor)!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 39: // Nada
                    MessageBox.Show("Infelizmente você não obteve prêmio, mais sorte na próxima vez!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }


        public string get_cpu_id()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["processorID"].Value.ToString();
                break;
            }
            return cpuInfo;
        }



        public string get_gpu_id()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            string motherBoard = "";
            foreach (ManagementObject mo in moc)
            {
                motherBoard = (string)mo["SerialNumber"];
            }
            return motherBoard;
        }


        public static string xorIt(string key, string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
                sb.Append((char)(input[i] ^ key[(i % key.Length)]));
            String result = sb.ToString();

            return result;
        }


        int giros_restantes = 0;

        public string HWID;


        public void hwid_and_roullet()
        {
            linkLabel2.Text = "HWID: " + HWID + "    -   Giros Restantes: 0";

            WebClient web = new WebClient();
            Stream stream = web.OpenRead("Sua hospedagem online");

            using (StreamReader reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    if (reader.ReadLine() == HWID)
                    {
                        giros_restantes = 1010;
                    }

                    if (giros_restantes == 1010)
                    {
                        giros_restantes = Convert.ToInt32(reader.ReadLine());
                        Properties.Settings.Default.roullet = giros_restantes;
                        Properties.Settings.Default.Save();
                        return;
                    }
                    giros_restantes++;
                }
            }
        }



        public void update()
        {
            WebClient web = new WebClient();
            Stream stream = web.OpenRead("Sua hospedagem online");

            using (StreamReader reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    if (reader.ReadLine() == HWID)
                    {
                        giros_restantes = 1010;
                    }

                    if (giros_restantes == 1010)
                    {
                        giros_restantes = Convert.ToInt32(reader.ReadLine());
                        Properties.Settings.Default.roullet = giros_restantes;
                        Properties.Settings.Default.Save();
                        return;
                    }
                    giros_restantes++;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            HWID = get_cpu_id() + get_gpu_id();

            Properties.Settings.Default.roullet = -1;
            Properties.Settings.Default.Save();



            if (Properties.Settings.Default.roullet == 0)
            {
                giros_restantes = 0;
                linkLabel2.Text = "HWID: " + HWID + "    -   Giros Restantes: 0";
            }


            if (Properties.Settings.Default.roullet == -1)
            {
                hwid_and_roullet();
                linkLabel2.Text = "HWID: " + HWID + "    -   Giros Restantes: " + giros_restantes;
            }

            if (Properties.Settings.Default.roullet >= 1)
            {
                giros_restantes = Properties.Settings.Default.roullet;
                linkLabel2.Text = "HWID: " + HWID + "    -   Giros Restantes: " + giros_restantes;
            }


            linkLabel2.Location = new Point(301, 582);

            if (MessageBox.Show("Termo de Uso:\nO Proprietário deste loader não se responsabiliza, expressa ou tacitamente pelo uso indevido das informações dos instrumentos, materiais disponibilizados ou dos programas utilizados, para quaisquer que sejam os fins, feito por qualquer usuário, sendo de inteira responsabilidade deste as eventuais lesões a direito próprio ou de terceiros, causadas ou não por este uso inadequado.\n\nCréditos: F!ckL4w/Magal.\nDiscord: Cyb3r_1nj3ct0r#8548\n\nDeseja Continuar?",
                            "Info",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.No)
            {
                Close();
            }
        }



        private async void btn_roleta_Click(object sender, EventArgs e)
        {
            if(giros_restantes >= 1)
            {
                giros_restantes--;
                linkLabel2.Text = "HWID: " + HWID + "    -   Giros Restantes: " + giros_restantes;
                Properties.Settings.Default.roullet -= 1;
                Properties.Settings.Default.Save();
                btn_roleta.Enabled = false;
                Random random = new Random();

                Button[] LeftArr = new Button[40] { btn_premio1, btn_premio2, btn_premio3, btn_premio4, btn_premio5, btn_premio6,
                                                btn_premio7, btn_premio8, btn_premio9, btn_premio10, btn_premio11, btn_premio12,
                                                btn_premio13, btn_premio14, btn_premio15, btn_premio16, btn_premio17, btn_premio18,
                                                btn_premio19, btn_premio20, btn_premio21, btn_premio22, btn_premio23, btn_premio24,
                                                btn_premio25, btn_premio26, btn_premio27, btn_premio28, btn_premio29, btn_premio30,
                                                btn_premio31, btn_premio32, btn_premio33, btn_premio34, btn_premio35, btn_premio36,
                                                btn_premio37, btn_premio38, btn_premio39, btn_premio40};


                int number_random = random.Next(100, 225);


                for (int i = 0; i < 39; i++)
                {
                    LeftArr[i].FlatAppearance.BorderColor = Color.FromArgb(32, 34, 37);
                }

                int index = 1;

                for (int i = 0; i < number_random; i++)
                {
                    await Task.Factory.StartNew(() => Thread.Sleep(35));
                    index++;

                    if (index <= 39)
                    {
                        if (index == 0)
                        {
                            LeftArr[39].FlatAppearance.BorderColor = Color.FromArgb(32, 34, 37);
                            LeftArr[index].FlatAppearance.BorderColor = Color.Gray;
                        }
                        else
                        {
                            LeftArr[index - 1].FlatAppearance.BorderColor = Color.FromArgb(32, 34, 37);
                            LeftArr[index].FlatAppearance.BorderColor = Color.Gray;
                        }
                    }
                    else
                    {
                        index = -1;
                    }

                    if ((i + 1) == number_random)
                    {
                        mensagem_premio(index);
                    }
                }
                btn_roleta.Enabled = true;
            }
            else if(giros_restantes == 0)
            {
                Properties.Settings.Default.roullet = 0;
                Properties.Settings.Default.Save();
                MessageBox.Show("Você não possuí mais fichas.\nProcure um vendedor se quiser jogar mais!",
                    "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(HWID);
            MessageBox.Show("HWID Copiada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
