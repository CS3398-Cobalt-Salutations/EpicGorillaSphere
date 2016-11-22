using UnityEngine;
using UnityEditor;
using NUnit.Framework;

// If Cloud Build fails, don't need to specify a method
// Implications:
// -> Can remove UnitTest.cs
// -> Can remove RunTests()
// -> Adding new unit tests is much easier
// -> Can set up test cases without providing default arguments from RunTests()

// Otherwise (if Cloud Build succeeds), UnitTest.cs is necessary, and the above truth values are negated

namespace GorirraTest
{
    [TestFixture]
    [Category("Keyring Tests")]
    internal class KeyringTests
    {
        [Test]
        [Category("General Tests")]
        public void Keyring_OverCapacity_AfterPersonalKeyAdded()
        {
            // string testName = System.Reflection.MethodBase.GetCurrentMethod().Name;

            GameObject testObject = new GameObject();
            testObject.AddComponent<Keyring>();
            Keyring testKeyring = testObject.GetComponent<Keyring>();
            testKeyring.maxCapacity = 0;

            GameObject testKeyObject = new GameObject();
            testKeyObject.AddComponent<Key>();
            Key testKey = testKeyObject.GetComponent<Key>();
            testKey.id = 0;
            testKey.isGlobal = false;

            bool keyAdded = testKeyring.AddKey(testKey);

            //UnitTest.MakeAssertion(keyAdded == true, "keyAdded == true", keyAdded.ToString(), testName);
            //UnitTest.MakeAssertion(testKeyring.PersonalKeyCount == 0, "testKeyring.PersonalKeyCount == 0", testKeyring.PersonalKeyCount.ToString(), testName);
            //UnitTest.MakeAssertion(Keyring.GlobalKeyCount == 0, "Keyring.GlobalKeyCount == 0", Keyring.GlobalKeyCount.ToString(), testName);

            try
            {
                Assert.True(keyAdded);
                Assert.AreEqual(testKeyring.PersonalKeyCount, 0);
                Assert.AreEqual(Keyring.GlobalKeyCount, 0);
            }
            catch (AssertionException e)
            {
                Debug.LogException(e);
                throw;
            }
        }

        [Test]
        [Category("Personal Keys Tests")]
        public void Keyring_NoPersonalKeys_AfterPersonalKeyAdded()
        {
            // string testName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            
            // Setup keyring
            GameObject testObject = new GameObject("Test Object");
            testObject.AddComponent<Keyring>();
            Keyring testKeyring = testObject.GetComponent<Keyring>();
            testKeyring.maxCapacity = 1;

            // Setup key
            GameObject testKeyObject = new GameObject("Test Key Object");
            testKeyObject.AddComponent<Key>();
            Key testKey = testKeyObject.GetComponent<Key>();
            testKey.id = 0;
            testKey.isGlobal = false;

            // Perform test
            bool keyAdded = testKeyring.AddKey(testKey);

            // Run assertions
            //UnitTest.MakeAssertion(keyAdded == true, "keyAdded == true", keyAdded.ToString(), testName);
            //UnitTest.MakeAssertion(testKeyring.PersonalKeyCount == 1, "testKeyring.PersonalKeyCount == 1", testKeyring.PersonalKeyCount.ToString(), testName);
            try
            {
                Assert.True(keyAdded);
                Assert.AreEqual(testKeyring.PersonalKeyCount, 1);
            }
            catch (AssertionException e)
            {
                Debug.LogException(e);
                throw;
            }
        }

        [Test]
        [Category("Global Keys Tests")]
        public void Keyring_GlobalKeysChanged_AfterPersonalKeyAdded()
        {
            // string testName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            
            // Setup keyring
            GameObject testObject = new GameObject("Test Object");
            testObject.AddComponent<Keyring>();
            Keyring testKeyring = testObject.GetComponent<Keyring>();
            testKeyring.maxCapacity = 1;

            // Setup key
            GameObject testKeyObject = new GameObject("Test Key Object");
            testKeyObject.AddComponent<Key>();
            Key testKey = testKeyObject.GetComponent<Key>();
            testKey.id = 0;
            testKey.isGlobal = false;

            // Perform test
            bool keyAdded = testKeyring.AddKey(testKey);

            // Run assertion
            //UnitTest.MakeAssertion(keyAdded == true, "keyAdded == true", keyAdded.ToString(), testName);
            //UnitTest.MakeAssertion(Keyring.GlobalKeyCount == 0, "Keyring.GlobalKeyCount == 0", Keyring.GlobalKeyCount.ToString(), testName);
            try
            {
                Assert.True(keyAdded);
                Assert.AreEqual(Keyring.GlobalKeyCount, 1); // 0, but set to 1 knowing it will fail
            }
            catch (AssertionException e)
            {
                Debug.LogException(e);
                throw;
            }
        }

        //[Test]
        //public void EditorTest()
        //{
        //    //Arrange
        //    var gameObject = new GameObject();

        //    //Act
        //    //Try to rename the GameObject
        //    var newGameObjectName = "My game object";
        //    gameObject.name = newGameObjectName;

        //    //Assert
        //    //The object has a new name
        //    Assert.AreEqual(newGameObjectName, gameObject.name);
        //}
    }
}