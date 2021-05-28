import java.lang.Math;

public class CannonTrajectory{
  private double x;
  private double y;
  public double vx;
  public double vy;
  private final double g = 9.81;

  CannonTrajectory(){
    this.x = 0;
    this.y = 0;
    this.vx = 0;
    this.vy = 0;
  }

  public double findTime(double initialVel, double angle){
    double finalAngle = Math.toRadians(angle);
    vx = initialVel * Math.cos(finalAngle);
    vy = initialVel * Math.sin(finalAngle);
    double time = (2 * vy) / g;
    return time;
  }

  public double getXLocation(double vx, double time){
    x = vx * time;

    return x;
  }

  public double getYLocation(double time, double vy){
    y = (vy * time) + (0.5 * g * time * time * -1);

    return y;
  }

  public double findDistance(double initialVel, double angle){
    double time = findTime(initialVel, angle);
    return time * vx;
  }
  public double findHeight(double initialVel, double angle){
    double time = findTime(initialVel, angle) / 2;
    return (vy * time) + (0.5 * g * time * time * -1);
  }
}
