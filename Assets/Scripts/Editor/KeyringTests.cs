using UnityEngine;
using UnityEditor;
using NUnit.Framework;

namespace GorirraTest
{
    [TestFixture]
    [Category("Keyring Tests")]
    internal class KeyringTests
    {
        public static void RunTests()
        {
            KeyringTests tests = new KeyringTests();
            tests.Keyring_OverCapacity_AfterPersonalKeyAdded();
            tests.Keyring_NoPersonalKeys_AfterPersonalKeyAdded();
            tests.Keyring_GlobalKeysChanged_AfterPersonalKeyAdded();
        }

        [Test]
        [Category("General Tests")]
        public void Keyring_OverCapacity_AfterPersonalKeyAdded()
        {
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

            try
            {
                Assert.That(keyAdded == true);
                Assert.That(testKeyring.PersonalKeyCount == 0);
                Assert.That(Keyring.GlobalKeyCount == 0);
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
            try
            {
                Assert.That(keyAdded == true);
                Assert.That(testKeyring.PersonalKeyCount == 1);
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
            try
            {
                Assert.That(keyAdded == true);
                Assert.That(Keyring.GlobalKeyCount == 0);
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