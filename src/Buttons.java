import javax.swing.*;
import java.awt.*;
import java.awt.geom.*;
import java.awt.event.*;

/** Class which puts the buttons onto the screen an and makes sure that they ahve the right Labels
 * Also sets upgrade labels
 * @author Ethan Bowles
 * @since March 25, 2021
*/
public class Buttons implements ActionListener{
  private JButton[][] btns = new JButton[4][2];
  private int x;
  private int y;
  private int size = 50;
  public static double[] upgradeVal = new double[8];

  private final double updgrade = 1.07;

  private boolean[] active = new boolean[8];

  private UpgradeLabels ul = new UpgradeLabels();

  private String[] startVals = {"Start","6000","72000","864000","10.368 M","124.42 M","1.493 B","17.916 B"};

  /**
  * Constructor for the Buttons Class
  * Sets the starting location for all of the buttons in the program and Instantiates some arrays
  * @param x - the x location of the buttons to start
  * @param y - the y location of the buttons to start
  */
  public Buttons(int x, int y){
    this.x = x;
    this.y = y;
    for(int i = 0; i < 4; i ++){
      for(int j = 0; j < 2; j++){
        btns[i][j] = new JButton();
      }
    }

    for(int i = 0; i < active.length; i++){
      active[i] = false;
    }

    for(int i = 0; i < upgradeVal.length; i++){
      upgradeVal[i] = 0;
    }
  }

  /**
  * Puts the first button on the screen and adds an actionlistener
  */
  public void buttonOneStart(){
    btns[0][0].setText(startVals[0]);
    btns[0][0].setBounds(x - 25,y,size,size);
    btns[0][0].setFocusPainted(false);
    btns[0][0].addActionListener(this);
    Main.frame.add(btns[0][0]);
  }

  /**
  * Checks to see if button already exists
  * Puts the upgrade label under the button
  * Puts the second button on the screen and adds an actionlistener
  */
  public void buttonTwoStart(){
    if(!active[0]){
      ul.setLabel(0,400,50,150);
      btns[1][0].setText(startVals[1]);
      btns[1][0].setBounds(x - 25,y + 100,size,size);
      btns[1][0].addActionListener(this);
      btns[1][0].setFocusPainted(false);
      Main.frame.add(btns[1][0]);
      active[0] = true;
    }
  }

  /**
  * Checks to see if button already exists
  * Puts the upgrade label under the button
  * Puts the third button on the screen and adds an actionlistener
  */
  public void buttonThreeStart(){
    if(!active[1]){
      ul.setLabel(1,6000,50,250);
      btns[2][0].setText(startVals[2]);
      btns[2][0].setBounds(x - 25,y + 200,size,size);
      btns[2][0].addActionListener(this);
      btns[2][0].setFocusPainted(false);
      Main.frame.add(btns[2][0]);
      active[1] = true;
    }
  }

  /**
  * Checks to see if button already exists
  * Puts the upgrade label under the button
  * Puts the fourth button on the screen and adds an actionlistener
  */
  public void buttonFourStart(){
    if(!active[2]){
      ul.setLabel(2,72000,50,350);
      btns[3][0].setFont(new Font("Arial", Font.PLAIN, 10));
      btns[3][0].setText(startVals[3]);
      btns[3][0].setBounds(x - 25,y + 300,size,size);
      btns[3][0].addActionListener(this);
      btns[3][0].setFocusPainted(false);
      Main.frame.add(btns[3][0]);
      active[2] = true;
    }
  }

  /**
  * Checks to see if button already exists
  * Puts the upgrade label under the button
  * Puts the fifth button on the screen and adds an actionlistener
  */
  public void buttonFiveStart(){
    if(!active[3]){
      ul.setLabel(3,864000,50,450);
      btns[0][1].setFont(new Font("Arial", Font.PLAIN, 9));
      btns[0][1].setText(startVals[4]);
      btns[0][1].setBounds(x + 715,y,size,size);
      btns[0][1].addActionListener(this);
      btns[0][1].setFocusPainted(false);
      Main.frame.add(btns[0][1]);
      active[3] = true;
    }
  }

  /**
  * Checks to see if button already exists
  * Puts the upgrade label under the button
  * Puts the sixth button on the screen and adds an actionlistener
  */
  public void buttonSixStart(){
    if(!active[4]){
      ul.setLabel(4,10368000,850,150);
      btns[1][1].setFont(new Font("Arial", Font.PLAIN, 9));
      btns[1][1].setText(startVals[5]);
      btns[1][1].setBounds(x + 715,y + 100,size,size);
      btns[1][1].addActionListener(this);
      btns[1][1].setFocusPainted(false);
      Main.frame.add(btns[1][1]);
      active[4] = true;
    }
  }

  /**
  * Checks to see if button already exists
  * Puts the upgrade label under the button
  * Puts the seventh button on the screen and adds an actionlistener
  */
  public void buttonSevenStart(){
    if(!active[5]){
      ul.setLabel(5,124416000,850,250);
      btns[2][1].setFont(new Font("Arial", Font.PLAIN, 9));
      btns[2][1].setText(startVals[6]);
      btns[2][1].setBounds(x + 715,y + 200,size,size);
      btns[2][1].addActionListener(this);
      btns[2][1].setFocusPainted(false);
      Main.frame.add(btns[2][1]);
      active[5] = true;
    }
  }

  /**
  * Checks to see if button already exists
  * Puts the upgrade label under the button
  * Puts the eigth button on the screen and adds an actionlistener
  */
  public void buttonEightStart(){
    if(!active[6]){
      ul.setLabel(6,1492992000,850,350);
      btns[3][1].setFont(new Font("Arial", Font.PLAIN, 9));
      btns[3][1].setText(startVals[7]);
      btns[3][1].setBounds(x + 715,y + 300,size,size);
      btns[3][1].addActionListener(this);
      btns[3][1].setFocusPainted(false);
      Main.frame.add(btns[3][1]);
      active[6] = true;
    }
  }

  /**
  * Checks to see if label already exists
  * and puts the upgrade label on the screen
  */
  public void buttonFinalStart(){
    if(!active[7]){
      ul.setLabel(7,17915904.0E3,850,450);
      active[7] = true;
    }
  }

  /**
  * Check which button is pressed
  * Check if the user has enough money to press the button
  * If there is another miner following add that button and Miner
  * Displays a new upgrade value and increases the corresponding own value
  * Changes the name of the button and unlocks other buttons
  * @param e - the event for each button press
  */
  @Override
  public void actionPerformed(ActionEvent e) {
    if(e.getSource() == btns[0][0]){
      upgradeVal[0] = Bars.own[0] * 1.07 * 400;
      if(Labels.totalCash >= upgradeVal[0]){
        Main.frame.setLayout(null);
        Labels.totalCash = Labels.totalCash - upgradeVal[0];
        Labels.cashLabel();
        Bars.own[0]++;
        upgradeVal[0] = Bars.own[0] * 1.07 * 400;
        UpgradeLabels.labels[0].setText("UPGRADE COST: " + upgradeVal[0]);
        String newName = "Buy";
        Animation.bar1.unlocked = true;
        btns[0][0].setText(newName);
        buttonTwoStart();
      }else{
        upgradeVal[0] = Bars.own[0] * 1.07 * 400;
      }
    }
    if(e.getSource() == btns[1][0]){
      upgradeVal[1] = Bars.own[1] * 1.07 * 6000 + 1;
      if(Labels.totalCash >= upgradeVal[1]){
        Main.frame.setLayout(null);
        Labels.totalCash = Labels.totalCash - upgradeVal[1];
        Labels.cashLabel();
        Bars.own[1]++;
        upgradeVal[1] = Bars.own[1] * 1.07 * 6000;
        UpgradeLabels.labels[1].setText("UPGRADE COST: " + upgradeVal[1]);
        String newName = "Buy";
        Animation.bar2.unlocked = true;
        btns[1][0].setText(newName);
        buttonThreeStart();
      }else{
        upgradeVal[1] = Bars.own[1] * 1.07 * 6000;
      }
    }
    if(e.getSource() == btns[2][0]){
      upgradeVal[2] = Bars.own[2] * 1.07 * 72000;
      if(Labels.totalCash >= upgradeVal[2]){
        Main.frame.setLayout(null);
        Labels.totalCash = Labels.totalCash - upgradeVal[2];
        Labels.cashLabel();
        Bars.own[2]++;
        upgradeVal[2] = Bars.own[2] * 1.07 * 72000;
        UpgradeLabels.labels[2].setText("UPGRADE COST: " + upgradeVal[2]);
        String newName = "Buy";
        Animation.bar3.unlocked = true;
        btns[2][0].setText(newName);
        buttonFourStart();
      }else{
        upgradeVal[2] = Bars.own[2] * 1.07 * 72000;
      }
    }
    if(e.getSource() == btns[3][0]){
      upgradeVal[3] = Bars.own[3] * 1.07 * 864000;
      if(Labels.totalCash >= upgradeVal[3]){
        Main.frame.setLayout(null);
        Labels.totalCash = Labels.totalCash - upgradeVal[3];
        Labels.cashLabel();
        Bars.own[3]++;
        upgradeVal[3] = Bars.own[3] * 1.07 * 864000;
        UpgradeLabels.labels[3].setText("UPGRADE COST: " + upgradeVal[3]);
        String newName = "Buy";
        Animation.bar4.unlocked = true;
        btns[3][0].setText(newName);
        buttonFiveStart();
      }else{
        upgradeVal[3] = Bars.own[3] * 1.07 * 864000;
      }
    }
    if(e.getSource() == btns[0][1]){
      upgradeVal[4] = Bars.own[4] * 1.07 * 10368000;
      if(Labels.totalCash >= upgradeVal[4]){
        Main.frame.setLayout(null);
        Labels.totalCash = Labels.totalCash - upgradeVal[4];
        Labels.cashLabel();
        Bars.own[4]++;
        upgradeVal[4] = Bars.own[4] * 1.07 * 10368000;
        UpgradeLabels.labels[4].setText("UPGRADE COST: " + upgradeVal[4]);
        String newName = "Buy";
        Animation.bar5.unlocked = true;
        btns[0][1].setText(newName);
        buttonSixStart();
      }else{
        upgradeVal[4] = Bars.own[4] * 1.07 * 10368000;
      }
    }

    if(e.getSource() == btns[1][1]){
      upgradeVal[5] = Bars.own[5] * 1.07 * 124416000;
      if(Labels.totalCash >= upgradeVal[5]){
        Main.frame.setLayout(null);
        Labels.totalCash = Labels.totalCash - upgradeVal[5];
        Labels.cashLabel();
        Bars.own[5]++;
        upgradeVal[5] = Bars.own[5] * 1.07 * 124416000;
        UpgradeLabels.labels[5].setText("UPGRADE COST: " + upgradeVal[5]);
        String newName = "Buy";
        Animation.bar6.unlocked = true;
        btns[1][1].setText(newName);
        buttonSevenStart();
      }else{
        upgradeVal[5] = Bars.own[5] * 1.07 * 124416000;
      }
    }

    if(e.getSource() == btns[2][1]){
      upgradeVal[6] = Bars.own[6] * 1.07 * 1492992000;
      if(Labels.totalCash >= upgradeVal[6]){
        Main.frame.setLayout(null);
        Labels.totalCash = Labels.totalCash - upgradeVal[6];
        Labels.cashLabel();
        Bars.own[6]++;
        upgradeVal[6] = Bars.own[6] * 1.07 * 1492992000;
        UpgradeLabels.labels[6].setText("UPGRADE COST: " + upgradeVal[6]);
        String newName = "Buy";
        Animation.bar7.unlocked = true;
        btns[2][1].setText(newName);
        buttonEightStart();
      }else{
        upgradeVal[6] = Bars.own[6] * 1.07 * 1492992000;
      }
    }

    if(e.getSource() == btns[3][1]){
      upgradeVal[7] = Bars.own[7] * 1.07 * 17915904.0E3;
      if(Labels.totalCash >= upgradeVal[7]){
        Main.frame.setLayout(null);
        Labels.totalCash = Labels.totalCash - upgradeVal[7];
        Labels.cashLabel();
        Bars.own[7]++;
        upgradeVal[7] = Bars.own[7] * 1.07 * 17915904.0E3;
        UpgradeLabels.labels[7].setText("UPGRADE COST: " + upgradeVal[7]);
        String newName = "Buy";
        Animation.bar8.unlocked = true;
        btns[3][1].setText(newName);
        buttonFinalStart();
      }else{
        upgradeVal[7] = Bars.own[7] * 1.07 * 17915904.0E3;
      }
    }
  }
}
