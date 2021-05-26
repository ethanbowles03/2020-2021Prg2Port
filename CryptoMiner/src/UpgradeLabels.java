import javax.swing.*;
import java.awt.*;
import java.awt.geom.*;
import java.awt.event.*;

/** UpgradeLabels class which makes all of the upgrade labels on the screen
 * @author Ethan Bowles
 * @since March 25, 2021
*/
public class UpgradeLabels{
  public static JLabel[] labels = new JLabel[8];

  /**
  * Constructor which Instantiates all of the labels
  */
  public UpgradeLabels(){
    for(int i = 0; i < 8; i++){
      labels[i] = new JLabel();
    }
  }

  /**
  * Method to set the contents of the upgrade labels and their setBounds
  * @param id - the id of the label you are using
  * @param val - the value of the next upgrade
  * @param x - the x location of the label
  * @param y - the y location of the label
  */
  public static void setLabel(int id, double val, int x, int y){
    labels[id].setText("UPGRADE COST: " + String.valueOf(1.07 * val));
    labels[id].setBounds(x - 25,y,600,50);
    Main.frame.add(labels[id]);
  }
}
