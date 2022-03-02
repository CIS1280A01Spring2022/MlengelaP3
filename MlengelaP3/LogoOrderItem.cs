/***********************************************************************
 * Program: Store Order
 * Programmer: Daudi Mlengela (dmlengela@cnm.edu)
 * Date: 1 March 2022
 * Purpose: Store order class with properties and constructors
 * *********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MlengelaP3
{
    public class LogoOrderItem
    {
        /***************************************************************
         * Constant declarations
         * *************************************************************/
        public const string PEN = "Pen";
        public const string COFFEE_MUG = "coffee_mug";
        public const string USB_DRIVE = "usb_drive";

        /**************************************************************
         * Fields declarations and they should be declared private
         * ************************************************************/

        private bool _hasLogo;
        private string _itemType;
        private int _numColors;
        private string _text;

        /***************************************************************
         * properties declarations which call the Calc() methods
         * *************************************************************/
        public bool HasLogo
         {
            get { return (_hasLogo); }

            set { _hasLogo = value; Calc(); }
         }
        /************************************************************
         * Three types: pens, coffee mugs, and usb drives
         * ***********************************************************/
         public string itemType
         {
            get { return (_itemType); }

            set 

            {
                if (value == PEN || value == COFFEE_MUG || value == USB_DRIVE)
                {
                    _itemType = value;
                    Calc();
                }
            }
        }

        public int numColors
        {
            get { return (numColors); }
            set { numColors = value; Calc();  }

        }
        public int numItems
        {
            get { return (numItems); }
            set { numItems = value; Calc(); }
        }

        public string text
        {
            get { return (_text); }
            set { _text = value; Calc(); }
        }
        
        /************************************************************
         * read-only auto-properties for the total price of all items
         * with all options
         * ****************************************/
        public int itemID { get; set;  }
        
        /***************************************************************
         * Instance Methods
         * *************************************************************/
        public int totalPrice { get; set;  }
        private void Calc ()
        {
            totalPrice = 0;

            switch (itemType)
            {
                case PEN: totalPrice = numItems * 100; break;
                case COFFEE_MUG: totalPrice = numItems * 350; break;
                case USB_DRIVE: totalPrice = numItems * 400; break;
            }

            if (HasLogo)
                totalPrice += 10 * numItems;

            if (!string.IsNullOrEmpty(text))
                totalPrice += 5 * numItems;

            totalPrice += 3 * numColors * numItems;
        }
        public string GetOrderSummary()
        {
            string output = "Order num " + itemID + ": " + numItems + " " +
                            itemType + (numItems == 1 ? "" : "s");

            if (HasLogo)
                output += " with " + numColors + " color logo";

            if (text != "")
                output += " with the following text: " + text;

            output += " Price: $" + (totalPrice / 100.0).ToString("0.00");

            return (output);
        }

        public LogoOrderItem(
           int itemIDValue,
           bool hasLogoValue,
           string itemTypeValue,
           int numColorsValue,
           int numItemsValue,
           string textValue
        )
        {
            itemID = itemIDValue;
            HasLogo = hasLogoValue;
            itemType = itemTypeValue;
            numColors = numColorsValue;
            numItems = numItemsValue;
            text = textValue;
        }

        /****************************************************************
         * Constructors 
         * **************************************************************/

        public LogoOrderItem(bool hasLogoValue, string textValue) :
           this(-1, hasLogoValue, COFFEE_MUG, 0, 0, textValue)
        {
        }

        public LogoOrderItem() : this(-1, false, COFFEE_MUG, 0, 0, "")
        {
        }
    }
}
