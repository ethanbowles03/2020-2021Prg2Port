import javax.swing.*;
import java.awt.*;
import java.awt.geom.*;
import java.util.Scanner;

public class CannonballShot extends JFrame{
  private double time = 0;
  private static double invel = 0;
  private static double inangle = 0;
  public CannonballShot(){
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setSize(1200,700);
  }

  public void paint(Graphics gp) {
    super.paint(gp);
    Graphics2D graphics = (Graphics2D) gp;
    Graphics2D graphics2 = (Graphics2D) gp;
    CannonTrajectory ct = new CannonTrajectory();
    Scanner sc = new Scanner(System.in);
    System.out.println("Enter the initial velocity of the cannonball: ");
    invel = sc.nextDouble();
    System.out.println("Enter the angle of which you want to launch the cannonball: ");
    inangle = sc.nextDouble();
    double newx = 0;
    double newy = 0;
    double oldx = 0;
    double oldy = 0;
    double yline = 0;
    double finalTime = ct.findTime(invel, inangle);
    double scalex = ct.findDistance(invel, inangle);
    double scaley = ct.findHeight(invel, inangle);
    scalex = 1000/scalex;
    scaley = 500/scaley;
    while(time <= finalTime){
      if(inangle > 65){
        newx =  scaley * ct.getXLocation(ct.vx,time);
        newy =  scaley * ct.getYLocation(time,ct.vy);
      }else{
        newx =  scalex * ct.getXLocation(ct.vx,time);
        newy =  scalex * ct.getYLocation(time,ct.vy);
      }
      Line2D line = new Line2D.Double(100+oldx, 600-oldy, 100+newx, 600-newy);
      graphics.draw(line);
      oldx = newx;
      oldy = newy;
      time += 0.00001;
    }
    if(inangle > 65){
      yline = ct.findHeight(invel, inangle) * scaley;
    }else{
      yline = ct.findHeight(invel, inangle) * scalex;
    }
    Line2D lineHeight = new Line2D.Double((newx/2) + 100,600-yline,(newx/2) + 100,600);
    Line2D lineWidth = new Line2D.Double(100,600,newx + 100,600);
    graphics.draw(lineWidth);
    graphics2.draw(lineHeight);
    System.out.println("Total time: " + finalTime);
    System.out.println("Maximum Height: " + ct.findHeight(invel, inangle));
    System.out.println("Initial Velocity: " + invel);
    System.out.println("Angle: " + inangle);
    System.out.println("Initial Velocity in X Direction: " + ct.vx);
    System.out.println("Initial Velocity in Y Direction: " + ct.vy);
    System.out.println("Force of gravity: 9.81");
   }

  public static void main(String[] args){
    CannonballShot cs = new CannonballShot();
    CannonTrajectory ct = new CannonTrajectory();
    cs.setVisible(true);
  }
}
