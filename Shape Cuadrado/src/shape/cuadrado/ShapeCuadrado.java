/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shape.cuadrado;

import javafx.animation.FillTransition;
import javafx.animation.Interpolator;
import javafx.animation.ParallelTransition;
import javafx.animation.PathTransition;
import javafx.animation.RotateTransition;
import javafx.animation.ScaleTransition;
import javafx.animation.Timeline;
import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.paint.Color;
import javafx.scene.paint.CycleMethod;
import javafx.scene.paint.LinearGradient;
import javafx.scene.paint.Stop;
import javafx.scene.shape.Circle;
import javafx.scene.shape.CubicCurveTo;
import javafx.scene.shape.MoveTo;
import javafx.scene.shape.Path;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;
import javafx.util.Duration;

/**
 *
 * @author Usuario
 */
public class ShapeCuadrado extends Application {

    @Override
    public void start(Stage primaryStage) {

        Group root = new Group();

        final Rectangle rectPath = new Rectangle(0, 0, 40, 40);
        rectPath.setArcHeight(10);
        rectPath.setArcWidth(10);
        rectPath.setFill(Color.ORANGE);
        
        LinearGradient color= new LinearGradient(0f, 1f, 1f, 0f, true, CycleMethod.NO_CYCLE, new 
         Stop[]{
            new Stop(0, Color.web("#f8bd55")),
            new Stop(0.14, Color.web("#c0fe56")),
            new Stop(0.28, Color.web("#5dfbc1")),
            new Stop(0.43, Color.web("#64c2f8")),
            new Stop(0.57, Color.web("#be4af7")),
            new Stop(0.71, Color.web("#ed5fc2")),
            new Stop(0.85, Color.web("#ef504c")),
            new Stop(1, Color.web("#f2660f"))});
        
        Circle cir=new Circle(950, 380, 50,color);
        Circle cir2=new Circle(450, 380, 50,color);
   
        root.getChildren().add(cir);
        root.getChildren().add(cir2);
        root.getChildren().add(rectPath);
        
        RotateTransition rt1
                = new RotateTransition(Duration.millis(200), cir);
        rt1.setByAngle(-360f);
        rt1.setCycleCount(Timeline.INDEFINITE);
        rt1.setInterpolator(Interpolator.LINEAR);

        RotateTransition rt2
                = new RotateTransition(Duration.millis(200), cir2);
        rt2.setByAngle(360f);
        rt2.setCycleCount(Timeline.INDEFINITE);
        rt2.setInterpolator(Interpolator.LINEAR);

        
        Path path = new Path();
        path.getElements().add(new MoveTo(400, 200));
        path.getElements().add(new CubicCurveTo(200, 300, 200, 500, 400, 600));
        path.getElements().add(new CubicCurveTo(600, 750, 800, 50, 1000, 200));
        path.getElements().add(new CubicCurveTo(1200, 300, 1200, 500, 1000, 600));
        path.getElements().add(new CubicCurveTo(800, 750, 600, 50, 400, 200));

        PathTransition pathTransition = new PathTransition();
        pathTransition.setDuration(Duration.millis(6000));
        pathTransition.setPath(path);
        pathTransition.setNode(rectPath);
        pathTransition.setInterpolator(Interpolator.LINEAR);
        pathTransition.setCycleCount(Timeline.INDEFINITE);
        //pathTransition.setAutoReverse(true);

        RotateTransition rotateTransition
                = new RotateTransition(Duration.millis(3000), rectPath);
        rotateTransition.setByAngle(360f);
        rotateTransition.setCycleCount(Timeline.INDEFINITE);
        rotateTransition.setAutoReverse(true);

        ScaleTransition scaleTransition
                = new ScaleTransition(Duration.millis(1000), rectPath);
        scaleTransition.setToX(2f);
        scaleTransition.setToY(2f);
        scaleTransition.setCycleCount(Timeline.INDEFINITE);
        scaleTransition.setAutoReverse(true);

        FillTransition ft = new FillTransition(Duration.millis(3000), rectPath, Color.RED, Color.BLUE);
        ft.setCycleCount(Timeline.INDEFINITE);
        ft.setAutoReverse(true);

        ParallelTransition parallelTransition = new ParallelTransition();
        parallelTransition.getChildren().addAll(pathTransition, rotateTransition, scaleTransition, ft,rt1,rt2);
        parallelTransition.setCycleCount(Timeline.INDEFINITE);
        parallelTransition.play();

        Scene scene = new Scene(root, 300, 250);
        primaryStage.setMaximized(true);
        primaryStage.setTitle("Hello World!");
        primaryStage.setScene(scene);
        primaryStage.show();
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        launch(args);
    }

}
