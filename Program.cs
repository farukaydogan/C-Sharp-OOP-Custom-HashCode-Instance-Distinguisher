namespace Wood
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory("test","date");
            Sunta sunta1 = new Sunta(300,500);
            Sunta sunta2 = new Sunta(400,500);
            Sunta sunta3 = new Sunta(300,500);
            Sunta sunta4 = new Sunta(400,500);
            Sunta sunta5 = new Sunta(400,500);
            Sunta sunta6 = new Sunta(300, 500);




            inventory[sunta1] += 3;
            inventory[sunta2] += 4;
            inventory[sunta3] += 5;
            inventory[sunta4] += 6;
            inventory[sunta5] += 7;
            inventory[sunta6] += 8;


            inventory.PrintStockQuantities();
        }
    }
}