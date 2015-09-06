using System;
using System.Collections.Generic;
using System.Linq;
using Project_Alpha.Classes.GameElements;
using Project_Alpha.Classes.GameElements.Items;

namespace Project_Alpha.Classes.Manager
{
    public class InventorySystem
    {
        private const int MaximumSlots = 10;

        public readonly List<ItemStack> InventoryRecords = new List<ItemStack>();

        public void AddItem(Item item, int quantityToAdd)
        {
            while (quantityToAdd > 0)
            {
                // If an object of this item type already exists in the inventory, and has room to stack more items,
                // then add as many as we can to that stack.
                if (InventoryRecords.Exists(x => (x.InventoryItem.Id == item.Id) && (x.Quantity < item.MaxQuantity)))
                {
                    // Get the item we're going to add quantity to
                    ItemStack inventoryRecord =
                    InventoryRecords.First(x => (x.InventoryItem.Id == item.Id) && (x.Quantity < item.MaxQuantity));
                    
                    // Calculate how many more can be added to this stack
                    int maxAddQuantity = (item.MaxQuantity - inventoryRecord.Quantity);

                    // Add to the stack (either the full quanity, or the amount that would make it reach the stack maximum)
                    int quantityToAddToStack = Math.Min(quantityToAdd, maxAddQuantity);

                    inventoryRecord.AddToQuantity(quantityToAddToStack);

                    // Decrease the quantityToAdd by the amount we added to the stack.
                    // If we added the total quantityToAdd to the stack, then this value will be 0, and we'll exit the 'while' loop.
                    quantityToAdd -= quantityToAddToStack;
                }
                else
                {
                    // We don't already have an existing inventoryRecord for this ObtainableItem object,
                    // so, add one to the list, if there is room.
                    if (InventoryRecords.Count < MaximumSlots)
                    {
                        // Don't set the quantity value here.
                        // The 'while' loop will take us back to the code above, which will add to the quantity.
                        InventoryRecords.Add(new ItemStack(item, 0));
                    }
                    else
                    {
                        // Throw an exception, or somehow let the user know they are out of inventory space.
                        // This exception here is just a quick example. Do something better in your code.
                        throw new Exception("There is no more space in the inventory");
                    }
                }
            }
        }

        public void RemovedItem(Item item, int quantityToRemoved)
        {
     
            while (quantityToRemoved > 0)
            {
                // If an object of this item type exists in the inventory, then removed as many as we can to that stack.
                if (InventoryRecords.Exists(x => (x.InventoryItem.Id == item.Id))) 
                {

                    // Get the item we're going to removed quantity to
                    ItemStack inventoryRecord =
                    InventoryRecords.First(x => (x.InventoryItem.Id == item.Id));

                    // Calculate how many can be removed by this stack
                    if (inventoryRecord.Quantity <= quantityToRemoved)
                    {
                        // Decrease the quantityToAdd by the amount we added to the stack.
                        // If we added the total quantityToAdd to the stack, then this value will be 0, and we'll exit the 'while' loop.
                        quantityToRemoved -= inventoryRecord.Quantity;
                        InventoryRecords.Remove(inventoryRecord);
                    }
                    else
                    {
                        inventoryRecord.RemoveToQuantity(quantityToRemoved);

                        // Decrease the quantityToAdd by the amount we added to the stack.
                        // If we added the total quantityToAdd to the stack, then this value will be 0, and we'll exit the 'while' loop.
                        quantityToRemoved = 0;
                    }

                }
                else
                {
                    // Throw an exception, or somehow let the user know they no item to removed in the inventory.
                    // This exception here is just a quick example. Do something better in your code.
                    throw new Exception("There is no item to removed in the inventory");
                }
            }
        }

        public override string ToString()
        {
            string info = "";

            info += "Verfügbare Slots: " + MaximumSlots.ToString() + "\n";
            info += "Belegte Slots:\n";
            foreach (ItemStack record in InventoryRecords)
            {
                info += record.InventoryItem.Title + " | " + record.Quantity.ToString() + "\n";
            }

            return info;
        }
    }
        
}
