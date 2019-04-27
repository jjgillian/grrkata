﻿using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        // naming convention of each unit test is as follows:
        // ClassUnderTest_Method_Objective_Outcome

        #region conjured item tests


        #endregion conjured item tests
        /// <summary>
        /// this unit test is for proving that the update of an item's Sellin property
        /// is properly updated at the end of the day, and done only once no matter
        /// how often the UpdateQuality() method is called
        /// </summary>
        [Test]
        public void GildedRose_UpdateQuality_ConjuredItem_success()
        {
            // in the production situation, the value for 
            // hasBeenRunToday would be taken from some persisted medium like 
            // a database. We use a hard coded value here just for the sake of 
            // test.
            bool hasBeenRunToday = false;
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Item", SellIn = 10, Quality = 30 } };
            GildedRose app = new GildedRose(Items, hasBeenRunToday);
            app.UpdateQuality();
            int expectedQuality = 28; // this is with the assumption that decrementing of quality the
            // item is by 2
            Assert.AreEqual(expectedQuality, Items[0].Quality);

          
        }
        #region Sellin unit tests   

        /// <summary>
        /// this unit test is for proving that the update of an item's Sellin property
        /// is properly updated at the end of the day, and done only once no matter
        /// how often the UpdateQuality() method is called
        /// </summary>
        [Test]
        public void GildedRose_UpdateQuality_SellinForAllItemsGetsUpdatedOnceDaily_success()
        {
            // in the production situation, the value for 
            // hasBeenRunToday would be taken from some persisted medium like 
            // a database. We use a hard coded value here just for the sake of 
            // test.
            bool hasBeenRunToday = false;
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 30 } };
            GildedRose app = new GildedRose(Items, hasBeenRunToday);
            app.UpdateQuality();
            int expectedSellIn = 9; // this is with the assumption that decrementing of Sellin of the
            // item is by 1
            Assert.AreEqual(expectedSellIn, Items[0].SellIn);

            // run again on the same day
            // the item MUST not get incremented twice on the same day                                    
            app.UpdateQuality();
            expectedSellIn = 9; // this is with the assumption that decrementing of Sellin of the
            // item is by 1
            Assert.AreEqual(expectedSellIn, Items[0].SellIn);
        }


        #endregion Sellin unit tests

        #region Quality Unit Tests

        [Test]
        public void GildedRose_UpdateQuality_QualityDegradesTwiceAsFast_When_SellinGoesBelowZero_success()
        {
            // in the production situation, the value for 
            // hasBeenRunToday would be taken from some persisted medium like 
            // a database. We use a hard coded value here just for the sake of 
            // test.
            bool hasBeenRunToday = false;
            int quality = 30;
            int decrement = -1;
            int scaleForExpiration = 2;
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 30 } };
            GildedRose app = new GildedRose(Items, hasBeenRunToday);
            app.UpdateQuality();
            // this is with the assumption that decrementing of quality 
            // is twice as fast when Sellin is below zero
            int expectedValue = quality + decrement * scaleForExpiration;
            Assert.AreEqual(expectedValue, Items[0].Quality);
        }

        /// <summary>
        /// this unit test is for proving that the update of an item's Quality property
        /// is properly updated at the end of the day, and done only once no matter
        /// how often the UpdateQuality() method is called
        /// </summary>
        [Test]
        public void GildedRose_UpdateQuality_QualityForAllItemsGetsUpdatedOnceDaily_success()
        {
            // in the production situation, the value for 
            // hasBeenRunToday would be taken from some persisted medium like 
            // a database. We use a hard coded value here just for the sake of 
            // test.
            bool hasBeenRunToday = false;
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 30 } };
            GildedRose app = new GildedRose(Items, hasBeenRunToday);
            app.UpdateQuality();
            int expectedQuality = 29; // this is with the assumption that decrementing of quality of the
            // item is by 1
            Assert.AreEqual(expectedQuality, Items[0].Quality);

            // run again on the same day
            // the item MUST not get incremented twice on the same day                                    
            app.UpdateQuality();
            Assert.AreEqual(expectedQuality, Items[0].Quality);
        }

        #endregion Quality Unit Tests

        #region Aged Brie Unit Tests
        /// <summary>
        /// this unit test is for verifying that the update Quality property
        /// increases with age
        /// </summary>
        [Test]
        public void GildedRose_UpdateQuality_AgedBrieQualityIncreases_With_Age_success()
        {
            // in the production situation, the value for 
            // hasBeenRunToday would be taken from some persisted medium like 
            // a database. We use a hard coded value here just for the sake of 
            // test.
            bool hasBeenRunToday = false;
            int quality = 30;
            int increment = 1;
            IList<Item> Items = new List<Item>
            { new Item { Name = "Aged Brie",
                SellIn = 0, Quality = 30 } };
            GildedRose app = new GildedRose(Items, hasBeenRunToday);
            app.UpdateQuality();
            // this is with the assumption that aged brie's quality increases with age
            int expectedValue = quality + increment;
            Assert.AreEqual(expectedValue, Items[0].Quality);
        }







        /// <summary>
            app.UpdateQuality();
        #endregion Aged Brie Unit Tests

        #region Backstage passes Unit Tests
        /// <summary>
        /// this unit test is for verifying that the quality of 
        /// backstage goes to zero when the Sellin is below zero
        /// </summary>
        [Test]
        public void GildedRose_UpdateQuality_BackstageQualityGoesToZero_When_SellinGoesBelowZero_success()
        {
            // in the production situation, the value for 
            // hasBeenRunToday would be taken from some persisted medium like 
            // a database. We use a hard coded value here just for the sake of 
            // test.
            bool hasBeenRunToday = false;
            int quality = 30;
            int increment = -1;
            int scaleForExpiration = quality;
            IList<Item> Items = new List<Item>
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 0, Quality = 30 } };
            GildedRose app = new GildedRose(Items, hasBeenRunToday);
            app.UpdateQuality();
            // this is with the assumption that decrementing of quality 
            // is twice as fast when Sellin is below zero
            int expectedValue = quality + increment * scaleForExpiration;
            Assert.AreEqual(expectedValue, Items[0].Quality);
        }




















        /// <summary>
                SellIn = 5, Quality = quality } };
            int expectedQuality = quality + increment; // this is with the assumption that incrementing of quality of the item is by "increment"
            app.UpdateQuality();











        /// <summary>
                SellIn = 10, Quality = quality } };
            int expectedQuality = quality + increment; // this is with the assumption that incrementing of quality of the item is by "increment"
            app.UpdateQuality();

        ///// <summary>
        //        SellIn = 10, Quality = quality } };
        //    int expectedQuality = quality + increment; // this is with the assumption that incrementing of quality of the item is by "increment"
        //    app.UpdateQuality();
        #endregion Backstage passes Unit Tests
    }
}