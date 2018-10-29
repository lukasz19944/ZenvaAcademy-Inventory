using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {

    public List<Item> items;

    private void Awake() {
        BuildDatabase();
    }

    public Item GetItem(int id) {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName) {
        return items.Find(item => item.title == itemName);
    }

    private void BuildDatabase() {
        items = new List<Item>() {
            new Item(0, "Diamond Sword", "A sword made of diamond", 
                    new Dictionary<string, int>() {
                        { "Power", 15},
                        { "Defence", 10}
                    }
            ),
            new Item(1, "Diamond Ore", "A diamond ore",
                    new Dictionary<string, int>() {
                        { "Value", 300},
                    }
            ),
            new Item(2, "Silver Pick", "A pick made of silver",
                    new Dictionary<string, int>() {
                        { "Power", 5},
                        { "Mining", 20}
                    }
            ),

        };
    }
}
