# 2023 - GD3 - Intro to C# - Exercises

## Overview 
This repository contains exercises used to learn the basics of C# in preparation for the development of the code for this module.

## Useful 
- [Markdown](https://docs.github.com/en/enterprise-cloud@latest/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax) in GitHub
- [Collections](https://www.tutorialspoint.com/csharp/csharp_collections.htm) in C#

### Exercise 1 - In-game Purchases
In this exercise you are required to write the code to simulate the in-game purchase
of game content (powerups, shields, etc.). You may assume that the code runs on a server
and so any new purchases can be stored directly in a collection. 

The code should allow the developer to perform the following:

- [ ] Create an entity to store the **purchase** data (unique purchase ID, price($), quantity, time, description[^1])
- [ ] Store **multiple** purchases in a collection.
- [ ] Prevent **duplicate** purchases.
- [ ] Store the purchases by **chronological order** and then by **purchase price** (highest first).

[^1]: Normally we would not store a description as this would be replaced by an item ID
