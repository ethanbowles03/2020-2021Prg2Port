//Creator: Ethan Bowles
//Dates: Sept 25 - 28, 2020

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.*;
import java.awt.geom.Line2D;
import javax.swing.JComponent;
import javax.swing.*;
import java.util.*;

/*
   A component that draws an alien face
*/
public class Ticket extends JComponent{
   public void paintComponent(Graphics g){
      // Recover Graphics2D
      Graphics2D g2 = (Graphics2D) g;

      int x = 260;
      int myNumBox = 225;
      int correctNumBox = 825;

      // Prints lines
      for(int i = 0; i < 4; i++){
        Line2D.Double line = new Line2D.Double(x, 0, x, 510);
        Line2D.Double line2 = new Line2D.Double(0, 510, 1300, 510);
        g2.setColor(Color.RED);
        g2.draw(line);
        g2.draw(line2);
        x = x + 260;
      }

      //Puts word on the page
      g.setFont(new Font("TimesRoman", Font.PLAIN, 30));
      g.setColor(Color.BLACK);
      g.drawString("Welcome to the Lottery Game", 475,550);
      g.setFont(new Font("TimesRoman", Font.PLAIN, 20));
      g.drawString("To play this game please select a different number from each column above. If you like your chosen numbers press submit in the bottom left.", 25,575);
      g.drawString("If any of your numbers match the winning numbers you win! GOOD LUCK!", 25,595);
      g.drawString("-Avoid choosing the same number twice as it will only count once if correct", 35,615);
      g.drawString("-For each number correct answer given 10^x will be added to your total!", 35,635);
      g.drawString("-Each time you play a dollar will be deducted from your total", 35,655);
      g.setColor(Color.BLUE);
      g.setFont(new Font("TimesRoman", Font.PLAIN, 25));
      g.drawString("My Numbers: ", 75,725);
      g.drawString("Correct Numbers: ", 635,725);
      g.setColor(Color.BLUE);
      g.drawString("You Won: ", 250,805);
      g.drawString("Total: ", 775,805);

      //Prints squares for user text and random numbers
      g2.setColor(Color.BLUE);
      Rectangle rectWon = new Rectangle(365,772,150,50);
      g2.draw(rectWon);

      g2.setColor(Color.BLUE);
      Rectangle rectTotal = new Rectangle(840,772,150,50);
      g2.draw(rectTotal);

      for(int i = 0; i < 5; i ++){
        g2.setColor(Color.BLUE);
        Rectangle rect = new Rectangle(myNumBox,692,50,50);
        g2.draw(rect);
        myNumBox = myNumBox + 75;
      }

      for(int i = 0; i < 5; i ++){
        g2.setColor(Color.BLUE);
        Rectangle rect2 = new Rectangle(correctNumBox,692,50,50);
        g2.draw(rect2);
        correctNumBox = correctNumBox + 75;
      }
   }
}
