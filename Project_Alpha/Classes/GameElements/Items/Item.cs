using System;

namespace Project_Alpha.Classes.GameElements.Items
{
    public abstract class Item
    {
        public Guid Id { get; set; }
        public string Title {get; protected set;}
        public int MaxQuantity { get; set; }

        protected Item()
        {
            Title = "Item";
            MaxQuantity = 1;
        }

        public virtual void ApplyItem()
        {
            //nothing happens here...it's always overridden
        }
    }
}
