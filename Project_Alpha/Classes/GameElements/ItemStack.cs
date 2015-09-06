using Project_Alpha.Classes.GameElements.Items;

namespace Project_Alpha.Classes.GameElements
{
    public class ItemStack 
    {
        public Item InventoryItem { get; private set; }
        public int Quantity { get; private set; }
 
        public ItemStack(Item item, int quantity)
        {
            InventoryItem = item;
            Quantity = quantity;
        }
 
        public void AddToQuantity(int amountToAdd)
        {
            Quantity += amountToAdd;
        }

        public void RemoveToQuantity(int amountToRemove)
        {
            Quantity -= amountToRemove;
        }
    }  
}
