
namespace WarehouseInventory
{
    public class DuplicateItemException : SystemException
    {
        public DuplicateItemException()
            : base("An item with the same ID already exists in the inventory.")
        {
        }

        public DuplicateItemException(string message)
            : base(message)
        {
        }

        public DuplicateItemException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    public class ItemNotFoundException : SystemException
    {
        public ItemNotFoundException()
            : base("The requested item was not found in the inventory.")
        {
        }
        public ItemNotFoundException(string message)
            : base(message)
        {
        }
        public ItemNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }


    public class InvalidQuantityException : SystemException
    {
        public InvalidQuantityException()
            : base("The quantity specified is invalid.")
        {
        }
        public InvalidQuantityException(string message)
            : base(message)
        {
        }
        public InvalidQuantityException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
}
