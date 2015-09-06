using Project_Alpha.Classes.Manager;

namespace Project_Alpha.Classes.Entity
{
    class Player
    {
        public string Name { get; private set; }
        public InventorySystem Inventory { get; private set; }

        public Player(string name)
        {
            this.Name = name;
            this.Inventory = new InventorySystem();
        }

        public override string ToString()
        {
            return "Name : " + this.Name + "\nInventory\n\n" + this.Inventory.ToString();
        }
    }
}
