# Computer_store
# Purpose:
All of this assignment is facilitate you to review some of the principal topics addressed in this course,
such as  classes, loops, arrays, arrays of objects, static attributes and static methods.

# General Guidelines When Writing Programs:
-	Introduce the following comments at the top of your source codes
<pre>//------------------------------------------------
// Project (number)
// © Your Name
// Written by: (your name and student id)
//------------------------------------------------</pre>
-	In a comment, give a general explanation of what your program does. As well as programming questions get more intricate, provide extra explanations is required.
-	Add comments to your program outlining the key steps of your program.
-	Show clear messages for users when waiting for them to input data from the keyboard.
-	All outputs must be displayed with clear messages and in a readable format.
-	Finish your program with an exit message so that the user knows that the program is finished.

# Part A
A Computer object has four attributes, a brand (String), a model (String), an SN (long), and a price (double). SN indicates the serial number of the computer.
For this part, you are required to design and implement the Computer class according to the following specifications:
-	Upon the creation of a computer object, the object must immediately be initialized with valid values; that is brand, model, SN and price. (Hint: Constructors.)
-	The design should allow enough flexibility so that the value of any of these attributes can be modified later on. For example, it should be possible to create a computer object with a given price then change its price later on. The design should also allow the user to obtain the value of any of the attributes. (Hint: Accessors & Mutators.)
-	The design should allow all information of an object to be displayed at once, through the  utilization of Console.Write() or Console.WriteLine() method.
-	It is required to know how many Computer objects have been created. For that, you need to add a method, called findNumberOfCreatedComputers(), to the class. This method must return the number of created Computer objects prior to the time this method is called. The method would simply return 0 if no computers have been created by the time the method is called. (Hint: You are allowed to add other attributes to the class.)
-	It is required to compare two Computer objects for equality. Two Computer objects are considered equal if they have the same brand, model and price.  

# Part B
You are the owner of a computer store and need help in keeping track of your computers. Write a driver program that will contain the following methods at least. Note: You can have the main function in a separate driver file, or in the same file if you prefer.
  1.	a main method, that will:
- a.	Display a welcome message
- b.	Prompt the computer store owner for the maximum number of computers (maxComputers) his/her computer store can contain. Create an empty array, called                   inventory, that will have the potential of keeping track of the created Computer objects.
- c.	Display a main menu with the following choices, and keep prompting the  user until they enter a number between 1 and 5 inclusive:
      <pre> -------------------------------------------------------------
          | What Do you want to do?                                     |
          |   1. Enrter new computer (password required)                |
          |   2. Change information of a computer (password required)   |
          |   3. Display all computers by a specific brand.             |
          |   4. Display all computers under a certain price.           |
          |   5. Quit                                                   |
            -------------------------------------------------------------</pre>
          <pre>  Please enter your choice:</pre>
          
- d.	When option 1 is entered:
   - I.  Prompt the computer store owner for his/her password. (Make sure you have a constant variable containing the password “password” – do not use any other                 password as it will be easier for me to check your Project). The computer store owner has 3 tries to enter the correct password. After the 3rd illegal                 entry, the main menu in figure 1 is re-displayed again.
   - II. If the correct password is entered, ask the owner how many computers he/she wants to enter. Check to make sure that there is enough space in the computer               store(array of Computer) to add these many computers. If so, add them; otherwise inform the owner that he/she can only add the number of remaining places               in the array. (How the computer information will be input/entered by the user, is up to you).
- e.	When option 2 is entered :
  - I.	Prompt the computer store owner for his/her password. (Make sure you have a constant containing the password “password” as a constant – do not use any                 other password as it will be easier for the marker to check your assignments). Again the computer store owner has 3 tries to enter the correct password.               After the 3rd illegal entry, the main menu in figure 1 is re- displayed again.

  - II. Ask the user which computer number he/she wishes to update. The computer number is the index in the array inventory. If there is no Computer                     object at the specified index location, display a message asking the user if he/she wishes to enter another computer, or quit this operation and go back to the main menu. If the entered index has a valid computer, display the current information of that computer in the following format:

<pre>Computer # X
Brand: brand of this computer 
Model: model of computer
SN: serial number (SN) of this computer 
Price: $price</pre>

Then ask the user which attribute they wish to change by displaying the following menu.
      <pre> ---------------------------------------------
          | What information would you like yo change?   |
          |   1. Brand                                   |
          |   2. Model                                   |
          |   3. SN                                      |
          |   4. Price                                   |
          |   5. Quit                                    |
           ---------------------------------------------</pre>
          <pre>  Enter your choice:</pre>

Once the user has entered a correct choice, make the changes to the attribute then display again all of the attributes on the screen to show that the attribute has been changed. Keep prompting the user for additional changes until the user enters 5. Each time the user is prompted for a choice make sure that a number from 1 to 5 is entered, otherwise keep prompting until a valid number is entered.

- f.	When option 3 is entered, prompt the user to enter a brand name. You then need to display the information of all computers that have that brand. (Hint: You             may use a static method, for instance called findComputersBy , which accepts a string for a brand name then performs the needed search).
- g.	When option 4 is entered, promtp the user to enter a value (representing a price). You then need to display all computers that have a vlaue smaller than that           entered value. (Hint: You may use a static method, for instance called findCheaperThan, which accepts a double value, for a price, then performs the needed             search).
- h.	When option 5 is entered, display a closing message and end the driver.

# Part C
After user press option 5 before you end the driver, you have to create the file name computerList.txt and use StreamWriter and list all the exciting computer in there.

# Part D
Try to read the file you saved file in the console.
