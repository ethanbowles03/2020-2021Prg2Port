/*
Creator: Ethan Bowles
Dates: Sept 25 - 28, 2020
This program is a simulation game of a lottery ticket. The user will pick 3 number.
Each of those number will be compared to winning number which will determin how much money the user makes or loses!

VERY IMPORTANT!!!!!!!

Please do not edit the save file!!

In order to play this game you need to enter the exact directory of the save file!
Please follow the steps below to ensure the game works

-> Go to the folder where the code and save file is located
-> Hover over the game total file and right click
-> Click on get info
-> Under general you will see the word where
-> Copy the words that are loacted here
-> Come back to the program and paste the info on line 57 where it say PASTEHERE
-> After entering the file name the program should run
*/

import javax.swing.*;
import java.awt.event.*;
import java.awt.Graphics;
import java.awt.Color;
import java.awt.*;
import java.util.Random;
import java.util.Scanner;
import java.io.*;

public class LotteryGUI extends JFrame implements ActionListener{

  //Creates the frame for the game to go into
  public JFrame frame = new JFrame("LotteryGame");

  //Creates all 250 buttons using 2D array along with making action buttons to play again and submit your results
  public JButton playAgain = new JButton("Play Again");
  public JButton submit = new JButton("Submit");
  public JButton[][] buttons = new JButton[5][50];

  //Creates the areas for informaiton to be displayed on the screen when certain buttons are press
  public JTextField box1, box2, box3, box4, box5;
  public JTextField boxc1, boxc2, boxc3, boxc4, boxc5;

  //Boxes which display how much is won and how much the user has
  public JTextField boxWon, boxTotal;

  //Variables that store the value of user selections of random numbers
  public int x1,x2,x3,x4,x5 = 1;
  public int xc1, xc2, xc3, xc4, xc5 = 0;

  //Variables that are later assigned values based off the comparison of user numbers and random numbers
  public int res1,res2,res3,res4,res5 = 1;

  //Directory of file (Please change before running this program)
  public String fileName = "PASTEHERE/GameTotal.txt";

  //Creates new font for the text boxes
  Font font1 = new Font("Arial", Font.PLAIN, 25);

  LotteryGUI(){
    //Method Calls
    window();
    btns();
    setInput();

    //Adds ticket object and displays
    Ticket ticket = new Ticket();
    frame.add(ticket);

    //Makes the frame visible
    frame.setVisible(true);
  }

  //Method to read the contents of the file and returns the last line as a string
  public String fileR(){
    //Variable being returned
    String lastLine = "1";
    try{
      String str;

      //Opens files anc creates reader objects
      FileReader fr = new FileReader(fileName);
      BufferedReader br = new BufferedReader(fr);

      //Runs through the line of code and stores the last line
      while((str = br.readLine()) != null){
        lastLine = str;
      }
      //Closes the file and returns last line
      br.close();
      return lastLine;
    } catch (IOException e){
      //Prints if the file is not found and returns last line as 1
      System.out.println("File Not Found");
      return lastLine;
    }
  }

  //Method that writes to the file and takes in the new total value
  public void fileW(String a){
    try{
      //Creates file writer objects
      FileWriter fw = new FileWriter(fileName);
      PrintWriter pw = new PrintWriter(fw);

      //prints new total to the file
      pw.println(a);

      //Closes the file
      pw.close();
    } catch (IOException e){
      System.out.println("Error");
    }
  }

  //Method that makes all of the button, gives them actions and attributes
  public void btns(){
    //Sets initial location
    int boxY = 10;
    int boxX = 10;

    //Loops through 2D array and
    for(int j = 0; j < 5; j++){
      for(int i = 0; i < 50; i++){
        //Creates title for each button
        String bTitle = Integer.toString(i + 1);
        //Makes each button and sets the bounds then adds them
        buttons[j][i] = new JButton(bTitle);
        buttons[j][i].setBounds(boxX,boxY,40,40);
        boxY = boxY + 50;
        frame.add(buttons[j][i]);
        //Sets action listener up for input
        buttons[j][i].addActionListener(this);
        //Makes separate rows for each button
        if(i == 9 || i == 19 || i == 29 || i == 39){
          boxX = boxX + 50;
          boxY = 10;
        }
      }
      //Resets at top and moves over to next section of buttons
      boxY = 10;
      boxX = boxX + 60;
    }
    //Makes and adds play again button
    playAgain.setBounds(5,775,100,50);
    frame.add(playAgain);
    playAgain.addActionListener(this);

    //Makes and adds submit button
    submit.setBounds(1220,775,75,50);
    frame.add(submit);
    submit.addActionListener(this);
  }

  //Makes properties of the window
  public void window(){
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setSize(1300,850);
    frame.setResizable(false);
  }

  //Adds actions when buttons are pressed by user
  public void actionPerformed(ActionEvent e) {
    //Loops through all buttons and gives them a output
    for(int j = 0; j < 5; j++){
      for(int i = 0; i < 50; i++){
        if(e.getSource() == buttons[j][i]){
          //Buttons in the first row are given a value and put in the first box
          if(j == 0){
            //Applies to all values of j
            //Sets value of button and makes it a String
            x1 = i + 1;
            String num1 = Integer.toString(x1);
            //Clear and sets font
            box1.setText("");
            box1.setFont(font1);
            //Reads lenght and places int in box
            if(num1.length() == 1){
              box1.setText(box1.getText().concat("  " + num1));
            }
            if(num1.length() == 2){
              box1.setText(box1.getText().concat(" " + num1));
            }
          }
          //Buttons in the second row are given a value and put in the second box
          if(j == 1){
            x2 = i + 1;
            String num2 = Integer.toString(x2);
            box2.setText("");
            box2.setFont(font1);
            if(num2.length() == 1){
              box2.setText(box2.getText().concat("  " + num2));
            }
            if(num2.length() == 2){
              box2.setText(box2.getText().concat(" " + num2));
            }
          }
          //Buttons in the third row are given a value and put in the third box
          if(j == 2){
            x3 = i + 1;
            String num3 = Integer.toString(x3);
            box3.setText("");
            box3.setFont(font1);
            if(num3.length() == 1){
              box3.setText(box3.getText().concat("  " + num3));
            }
            if(num3.length() == 2){
              box3.setText(box3.getText().concat(" " + num3));
            }
          }
          //Buttons in the fourth row are given a value and put in the fourth box
          if(j == 3){
            x4 = i + 1;
            String num4 = Integer.toString(x4);
            box4.setText("");
            box4.setFont(font1);
            if(num4.length() == 1){
              box4.setText(box4.getText().concat("  " + num4));
            }
            if(num4.length() == 2){
              box4.setText(box4.getText().concat(" " + num4));
            }
            //Buttons in the fifth row are given a value and put in the fifth box
          }if(j == 4){
            x5 = i + 1;
            String num5 = Integer.toString(x5);
            box5.setText("");
            box5.setFont(font1);
            if(num5.length() == 1){
              box5.setText(box5.getText().concat("  " + num5));
            }
            if(num5.length() == 2){
              box5.setText(box5.getText().concat(" " + num5));
            }
          }
        }
      }
    }
    //Cleares all of the user, random and winnings boxes on the screan
    if(e.getSource() == playAgain){
      clearBoxes();
    }

    // Actions performed when the user submits their answers
    if(e.getSource() == submit){
      //Checks to see if the random values are not 0. If they arent it clears the boxes
      if(xc1 != 0 || xc2 != 0 || xc3 != 0 || xc4 != 0 || xc5 != 0){
        clearBoxes();
      } else {
        //Checks to see if the user input all the info and if not it clears the boxes
        if(x1 == 0 || x2 == 0 || x3 == 0 || x4 == 0 || x5 == 0){
          clearBoxes();
        }else{
          //Deducts from total every time
          int lose = -1;
          //Resets text and font
          boxWon.setText("");
          boxWon.setFont(font1);
          boxTotal.setText("");
          boxTotal.setFont(font1);
          //Calls random number method
          randomNum();
          //Reads file and calculates the running total
          int runningTotal = Integer.parseInt(fileR());
          if(compare() == 0){
            runningTotal = runningTotal - 1;
          } else {
            runningTotal = runningTotal + compare() - 1;
          }
          //Prints the new total back to file and adds amount won and new total to screen
          String totalWon = Integer.toString(runningTotal);
          fileW(totalWon);
          String finWon = Integer.toString(compare());
          boxWon.setText(boxWon.getText().concat(" " + finWon));
          boxTotal.setText(boxTotal.getText().concat(" " + totalWon));
        }
      }
    }
  }

  //Sets the bounds and properties for all of the text fields
  public void setInput(){
        box1 = new JTextField();
        box1.setEditable(false);
        box1.setBounds(223,690,54,54);
        frame.add(box1);
        box2 = new JTextField();
        box2.setEditable(false);
        box2.setBounds(298,690,54,54);
        frame.add(box2);
        box3 = new JTextField();
        box3.setEditable(false);
        box3.setBounds(373,690,54,54);
        frame.add(box3);
        box4 = new JTextField();
        box4.setEditable(false);
        box4.setBounds(448,690,54,54);
        frame.add(box4);
        box5 = new JTextField();
        box5.setEditable(false);
        box5.setBounds(523,690,54,54);
        frame.add(box5);
        boxc1 = new JTextField();
        boxc1.setEditable(false);
        boxc1.setBounds(823,690,54,54);
        frame.add(boxc1);
        boxc2 = new JTextField();
        boxc2.setEditable(false);
        boxc2.setBounds(898,690,54,54);
        frame.add(boxc2);
        boxc3 = new JTextField();
        boxc3.setEditable(false);
        boxc3.setBounds(973,690,54,54);
        frame.add(boxc3);
        boxc4 = new JTextField();
        boxc4.setEditable(false);
        boxc4.setBounds(1048,690,54,54);
        frame.add(boxc4);
        boxc5 = new JTextField();
        boxc5.setEditable(false);
        boxc5.setBounds(1123,690,54,54);
        frame.add(boxc5);
        boxWon = new JTextField();
        boxWon.setEditable(false);
        boxWon.setBounds(363,770,154,54);
        frame.add(boxWon);
        boxTotal = new JTextField();
        boxTotal.setEditable(false);
        boxTotal.setBounds(838,770,154,54);
        frame.add(boxTotal);

    }

  //Creates 5 random numbers between 0 - 50
  public void randomNum(){
    int upperbound = 50;
    Random rand1 = new Random();
    Random rand2 = new Random();
    Random rand3 = new Random();
    Random rand4 = new Random();
    Random rand5 = new Random();
    int random1 = rand1.nextInt(upperbound);
    int random2 = rand2.nextInt(upperbound);
    int random3 = rand3.nextInt(upperbound);
    int random4 = rand4.nextInt(upperbound);
    int random5 = rand5.nextInt(upperbound);
    xc1 = random1 + 1;
    xc2 = random2 + 1;
    xc3 = random3 + 1;
    xc4 = random4 + 1;
    xc5 = random5 + 1;
    //Checks for duplicates
    if(xc1 == xc2 || xc1 == xc3 || xc1 == xc4 || xc1 == xc5 || xc2 == xc3 || xc2 == xc4 || xc2 == xc5 || xc3 == xc4 || xc3 == xc5 || xc4 == xc5){
      randomNum();
    }
    //Prints the random numbers in boxes and centers values
    String numc1 = Integer.toString(xc1);
    String numc2 = Integer.toString(xc2);
    String numc3 = Integer.toString(xc3);
    String numc4 = Integer.toString(xc4);
    String numc5 = Integer.toString(xc5);
    boxc1.setText("");
    boxc2.setText("");
    boxc3.setText("");
    boxc4.setText("");
    boxc5.setText("");
    boxc1.setFont(font1);
    boxc2.setFont(font1);
    boxc3.setFont(font1);
    boxc4.setFont(font1);
    boxc5.setFont(font1);
    if(numc1.length() == 1){
      boxc1.setText(boxc1.getText().concat("  " + numc1));
    }
    if(numc1.length() == 2){
      boxc1.setText(boxc1.getText().concat(" " + numc1));
    }
    if(numc2.length() == 1){
      boxc2.setText(boxc2.getText().concat("  " + numc2));
    }
    if(numc2.length() == 2){
      boxc2.setText(boxc2.getText().concat(" " + numc2));
    }
    if(numc3.length() == 1){
      boxc3.setText(boxc3.getText().concat("  " + numc3));
    }
    if(numc3.length() == 2){
      boxc3.setText(boxc3.getText().concat(" " + numc3));
    }
    if(numc4.length() == 1){
      boxc4.setText(boxc4.getText().concat("  " + numc4));
    }
    if(numc4.length() == 2){
      boxc4.setText(boxc4.getText().concat(" " + numc4));
    }
    if(numc5.length() == 1){
      boxc5.setText(boxc5.getText().concat("  " + numc5));
    }
    if(numc5.length() == 2){
      boxc5.setText(boxc5.getText().concat(" " + numc5));
    }
  }

  //Clears all text boxes
  public void clearBoxes(){
    x1 = 0;
    x2 = 0;
    x3 = 0;
    x4 = 0;
    x5 = 0;
    xc1 = 0;
    xc2 = 0;
    xc3 = 0;
    xc4 = 0;
    xc5 = 0;
    box1.setText("");
    box2.setText("");
    box3.setText("");
    box4.setText("");
    box5.setText("");
    boxc1.setText("");
    boxc2.setText("");
    boxc3.setText("");
    boxc4.setText("");
    boxc5.setText("");
    boxWon.setText("");
  }

  //Compares user data with random number and then awards money to user if won
  public int compare(){
    res1 = 1;
    res2 = 1;
    res3 = 1;
    res4 = 1;
    res5 = 1;
    int result = 0;
    if(xc1 == x1 || xc1 == x2 || xc1 == x3 || xc1 == x4 || xc1 == x5){
      res1 = 10;
    }
    if(xc2 == x1 || xc2 == x2 || xc2 == x3 || xc2 == x4 || xc2 == x5){
      res2 = 10;
    }
    if(xc3 == x1 || xc3 == x2 || xc3 == x3 || xc3 == x4 || xc3 == x5){
      res3 = 10;
    }
    if(xc4 == x1 || xc4 == x2 || xc4 == x3 || xc4 == x4 || xc4 == x5){
      res4 = 10;
    }
    if(xc5 == x1 || xc5 == x2 || xc5 == x3 || xc5 == x4 || xc5 == x5){
      res5 = 10;
    }
    //Calculates amount won
    result = res1 * res2 * res3 * res4 * res5;
    if(result == 1){
      result = 0;
    }
    return result;
  }

  //Main method
  public static void main(String[] args){
    new LotteryGUI();
  }
}
