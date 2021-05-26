import javax.swing.*;
import java.awt.*;
import java.awt.geom.*;
import java.awt.event.*;

/** Class which makes the currecny exchange button at the buttom of the screen
 * @author Ethan Bowles
 * @since March 25, 2021
*/
public class CashOut extends JButton implements ActionListener{
  /**
  * Constructor for the CashOut Class
  * Sets the bounds and dimenstions of the button and adds it to the screen
  * Adds an actionlistener to the button
  */
  public CashOut(){
    this.setBounds(5,530,125,50);
    this.setText("Cash-Out Crypto");
    this.setFocusPainted(false);
    addActionListener(this);
    Main.frame.setLayout(null);
    Main.frame.add(this);
  }

  /**
  * Method which read the input when this button class is pressed
  * Read the crypto label in the middle of the screen and check for commas
  * Multiply the value of the label and the amount of crypto the user owns and
  * add it to the total cash label
  * Set the crypto label to 0 and refresh labels
  * @param e - the input from this button class
  */
  @Override
  public void actionPerformed(ActionEvent e) {
    if(e.getSource() == this){
      String nums[] = Labels.cryptoLabel.getText().substring(6).split(",");
      String finNum = "";
      for(String num : nums){
        try{
          finNum += num;
        }catch(Exception ae){

        }
      }
      Labels.totalCash += Labels.totalVal * Double.parseDouble(finNum);
      Labels.cashLabel();
      Labels.totalVal = 0;
      Labels.totalLabel();
    }
  }
}
