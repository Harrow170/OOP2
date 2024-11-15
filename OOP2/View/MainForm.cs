using OOP2.Model;
using OOP2.Services;
using OOP2.View.Tabs;
//using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;
using System;
using Microsoft.VisualBasic.Devices;



namespace OOP2
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Ïîëó÷àåò èëè çàäàåò îáúåêò <see cref="Store"/>, ïðåäñòàâëÿþùèé ìàãàçèí.
        /// </summary>
        Store _store { get; set; }
        /// <summary>
        /// Ïóòü äî ïàïêè ñ ôàéëîì ñîõðàíåíèÿ.
        /// </summary>
        string _appFolderPath { get; set; }
        /// <summary>
        /// Íàñòðîéêè ñåðèàëèçàòîðà.
        /// </summary>
        JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            Formatting = Formatting.Indented
        };

        /// <summary>
        /// Êîíñòðóêòîð ãëàâíîé ôîðìû.
        /// Èíèöèàëèçèðóåò êîìïîíåíòû è çàãðóæàåò äàííûå èç ôàéëà ñîõðàíåíèÿ, åñëè îíè ñóùåñòâóþò.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _store = new Store();
            // Ïîëó÷åíèå ïóòè ê ôàéëó ñ äàííûìè ïðèëîæåíèÿ
            string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _appFolderPath = Path.Combine(appDataFolderPath, "avradev", "OOP");
            if (!Directory.Exists(_appFolderPath))
            {
                Directory.CreateDirectory(_appFolderPath);
            }
            // ×òåíèå äàííûõ èç ôàéëà ñîõðàíåíèÿ
            if (File.Exists(_appFolderPath + @"\data.json"))
            {
                try
                {
                    // ×òåíèå JSON èç ôàéëà
                    //string jsonString = File.ReadAllText(_appFolderPath + @"\data.json");
                    // Äåñåðèàëèçàöèÿ JSON â îáúåêò
                    Store data = JsonConvert.DeserializeObject<Store>(File.ReadAllText(_appFolderPath + @"\data.json"), _settings)!;
                    //Store? data = JsonConvert.DeserializeObject<Store>(jsonString, _settings);
                    //Store data = JsonSerializer.Deserialize<Store>(jsonString)!;
                    // Çàïèñü äàííûõ â ïðîâàéäåð
                    if (data != null) _store = data;
                }
                catch
                {
                    Console.WriteLine();
                }
            }
            ItemsTab.Items = _store.Items;
            CustomersTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;

            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;

            OrdersTab.Customers = _store.Customers;
        }

        /// <summary>
        /// Îáðàáîò÷èê ñîáûòèÿ çàêðûòèÿ ôîðìû.
        /// Ñåðèàëèçóåò äàííûå è ñîõðàíÿåò èõ â ôàéë.
        /// </summary>
        /// <param name="sender">Èñòî÷íèê ñîáûòèÿ.</param>
        /// <param name="e">Àðãóìåíòû ñîáûòèÿ çàêðûòèÿ ôîðìû.</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Îòêðûâàåì ïîòîê äëÿ çàïèñè â ôàéë
            //using FileStream stream = new FileStream(_appFolderPath + @"\data.json", FileMode.Create);
            // Ñåðèàëèçóåì ñïèñîê êíèã â XML è çàïèñûâàåì åãî â ôàéë
            //JsonConvert.SerializeObject(stream, Formatting.Indented, _settings);
            // serialize JSON directly to a file
            File.WriteAllText(_appFolderPath + @"\data.json", JsonConvert.SerializeObject(_store, Formatting.Indented, _settings));
            //JsonSerializer.Serialize(stream, _store);
        }

        /// <summary>
        /// Ñîáûòèå ñìåíû âêëàäêè.
        /// </summary>
        /// <param name="sender">Èñòî÷íèê ñîáûòèÿ.</param>
        /// <param name="e">Àðãóìåíòû.</param>
        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartsTab.RefreshData();
            OrdersTab.RefreshData();
        }
    }
}