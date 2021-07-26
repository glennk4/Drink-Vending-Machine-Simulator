using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drink_Vending_Machine_Simulator
{
    public partial class Form1 : Form
    {
        const string COKE_NAME = "Coca-Cola";
        const decimal COKE_PRICE = 0.85m;
        const string PEPPER_NAME = "Dr Pepper";
        const decimal PEPPER_PRICE = 0.85m;
        const string FANTA_NAME = "Fanta";
        const decimal FANTA_PRICE = 1.00m; 
        const string PEPSI_NAME = "Pepsi";
        const decimal PEPSI_PRICE = 1.00m;
        const string SPRITE_NAME = "Sprite";
        const decimal SPRITE_PRICE = 0.50m;

        List<Drink> drinks = new List<Drink>();
        int initialStock = 20;
        decimal totalSales = 0.0m; 


        public Form1()
        {
            InitializeComponent();

            
            drinks.Add(new Drink() { drinkName = COKE_NAME, drinkCost = COKE_PRICE, stock = initialStock});
            drinks.Add(new Drink() { drinkName = PEPPER_NAME, drinkCost = PEPPER_PRICE, stock = initialStock });
            drinks.Add(new Drink() { drinkName = FANTA_NAME, drinkCost = FANTA_PRICE, stock = initialStock });
            drinks.Add(new Drink() { drinkName = PEPPER_NAME, drinkCost = PEPPER_PRICE, stock = initialStock });
            drinks.Add(new Drink() { drinkName = SPRITE_NAME, drinkCost = SPRITE_PRICE, stock = initialStock }); 
        }

        private void CokeBox_Click(object sender, EventArgs e)
        {
            if (drinks[0].stock > 0)
            {
                totalSales += COKE_PRICE;
                SaleOutput.Text = totalSales.ToString("c");
                drinks[0].stock--;
                CokeStockOutput.Text = drinks[0].stock.ToString(); 

            }
            else
            {
                CokeStockOutput.ForeColor = Color.Red; 
            }
        }

        private void PepperBox_Click(object sender, EventArgs e)
        {
            if (drinks[1].stock > 0)
            {
                totalSales += PEPPER_PRICE;
                SaleOutput.Text = totalSales.ToString("c");
                drinks[1].stock--;
                PepperStockOutput.Text = drinks[1].stock.ToString(); 
            }
            else
            {
                PepperStockOutput.ForeColor = Color.Red;
            }
        }

        private void FantaBox_Click(object sender, EventArgs e)
        {
            if (drinks[2].stock > 0)
            {
                totalSales += FANTA_PRICE;
                SaleOutput.Text = totalSales.ToString("c");
                drinks[2].stock--;
                FantaStockOutput.Text = drinks[2].stock.ToString(); 
            }
            else
            {
                FantaStockOutput.ForeColor = Color.Red;
            }
        }

        private void PepsiBox_Click(object sender, EventArgs e)
        {
            if (drinks[3].stock > 0)
            {
                totalSales += PEPSI_PRICE;
                SaleOutput.Text = totalSales.ToString("c");
                drinks[3].stock--;
                PepperStockOutput.Text = drinks[3].stock.ToString(); 
            }
            else
            {
                PepsiStockOutput.ForeColor = Color.Red;
            }
        }

        private void SpriteBox_Click(object sender, EventArgs e)
        {
            if (drinks[4].stock > 0)
            {
                totalSales += SPRITE_PRICE;
                SaleOutput.Text = totalSales.ToString("c");
                drinks[4].stock--;
                SpriteStockOutput.Text = drinks[4].stock.ToString(); 
            }
            else
            {
                SpriteStockOutput.ForeColor = Color.Red;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }

    class Drink
    {
        public string drinkName;
        public decimal drinkCost;
        public int stock;
        

    }
}
