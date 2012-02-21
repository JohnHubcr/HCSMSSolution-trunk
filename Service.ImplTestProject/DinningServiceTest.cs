﻿using HCSMS.Service.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using HCSMS.Model;
using System.Collections.Generic;

namespace Service.ImplTestProject
{
    
    
    /// <summary>
    ///这是 DinningServiceTest 的测试类，旨在
    ///包含所有 DinningServiceTest 单元测试
    ///</summary>
    [TestClass()]
    public class DinningServiceTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试属性
        // 
        //编写测试时，还可使用以下属性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///ChangeItem 的测试
        ///</summary>
        [TestMethod()]     
        public void ChangeItemTest()
        {
            DinningService target = new DinningService(); // TODO: 初始化为适当的值
            string tableNumber = "002"; // TODO: 初始化为适当的值
            Dictionary<Item, Item> itemPair = new Dictionary<Item,Item>(); // TODO: 初始化为适当的值
            Item item1 = new Item();
            item1.Id = "001";
            Item item2 = new Item();
            item2.Id = "002";

            itemPair.Add(item1, item2);

            target.ChangeItem(tableNumber, itemPair);
            
        }
    }
}
