namespace GildedRoseTest
{
    internal class Product
    {
        public string Name { get; private set; }
        public int SellIn { get; private set; }
        public int Quality { get; private set; }
        public string Conjured { get; private set; } = string.Empty;
        public Product(string name, int sellin, int quality)
        {
            Name = name;
            SellIn = sellin;
            Quality = quality;
        }
        public Product(string name, int sellin, int quality, string conjured)
        {
            Name = name;
            SellIn = sellin;
            Quality = quality;
            Conjured = conjured;
        }

        
       


        internal void UpdateProduct()
        {
            switch (this.Name)
            {
                case "Aged Brie":
                    this.SellIn--;
                    this.Quality++;
                    break;
                    
                case "Sulfuras":
                    this.SellIn = this.SellIn;
                    this.Quality = 80;
                    break;
                    
                case "Backstage passes":
                    SellIn--;
                    

                        if (SellIn < 10 && SellIn > 5)
                        {
                            Quality = Quality + 2;
                        }
                        else if (SellIn <= 5 && SellIn > 0) 
                        {
                            Quality = Quality + 3;
                        }
                        SellIn--;
                    if(SellIn == 0) Quality = 0;


                    break;
                    
                default:
                    
                    if (Conjured != string.Empty)
                    {
                        SellIn--;
                        Quality = Quality - 2;
                        
                    }
                    
                    else
                    {
                        this.SellIn--;
                        this.Quality--;
                        if (SellIn <= 0)
                        {
                            Quality--;
                        }
                        else if (Quality <= 0)
                        {
                            Quality = 0;
                        }
                        else this.Quality = Quality;
                    }
                        break;
                         
                    

            }




        }
        
    }
}