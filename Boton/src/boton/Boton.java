/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package boton;

import java.util.Random;
import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.application.Application;
import javafx.beans.property.BooleanProperty;
import javafx.beans.property.SimpleBooleanProperty;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Rectangle2D;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.input.KeyCode;
import javafx.scene.input.KeyEvent;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Pane;
import javafx.stage.Screen;
import javafx.stage.Stage;
import javafx.stage.StageStyle;
import javafx.stage.WindowEvent;
import javafx.util.Duration;

/**
 *
 * @author Usuario
 */
public class Boton extends Application {

    @Override
    public void start(Stage stage) {
        Button btn = new Button();
        Pane root = new Pane();
        Scene scene = new Scene(root, 500, 500);
        root.getChildren().add(btn);
        btn.setText("hey");

        Random rnd = new Random();
        Rectangle2D primaryScreenBounds = Screen.getPrimary().getVisualBounds();
        /*
        scene.setOnMouseMoved(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                btn.setTranslateX(rnd.nextInt((int) (scene.getWidth()-btn.getWidth())));
                btn.setTranslateY(rnd.nextInt((int) (scene.getHeight()-btn.getHeight())));               
            }
        });*/

        btn.setOnMouseMoved(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                stage.setX(rnd.nextInt((int) (primaryScreenBounds.getMinX() + primaryScreenBounds.getWidth() - scene.getWidth())));
                stage.setY(rnd.nextInt((int) (primaryScreenBounds.getMinY() + primaryScreenBounds.getHeight() - scene.getHeight())));
                btn.setTranslateX(rnd.nextInt((int) (scene.getWidth() - btn.getWidth())));
                btn.setTranslateY(rnd.nextInt((int) (scene.getHeight() - btn.getHeight())));
            }
        });

        Timeline timeline = new Timeline(new KeyFrame(
                Duration.seconds(2), new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent event) {
                btn.setScaleX(btn.getScaleX() + 0.3);
                btn.setScaleY(btn.getScaleY() + 0.3);
            }
        }));
        timeline.setCycleCount(Timeline.INDEFINITE);
        timeline.play();

        
        //Evitar que se cierre con alt+f4
        final BooleanProperty ignoreCloseRequest = new SimpleBooleanProperty(false);
        stage.addEventFilter(KeyEvent.KEY_PRESSED, new EventHandler<KeyEvent>() {
            @Override
            public void handle(final KeyEvent event) {
                if (event.getCode() == KeyCode.F4 && event.isAltDown()) {
                    event.consume();
                    ignoreCloseRequest.set(true);
                }
            }
        });

        stage.setOnCloseRequest(new EventHandler<WindowEvent>() {
            @Override
            public void handle(final WindowEvent event) {
                if (ignoreCloseRequest.get()) {
                    event.consume();
                    ignoreCloseRequest.set(false);
                }
            }
        });
        /*
        if you want to disabled only maximize button than use
        stage.resizableProperty().setValue(Boolean.FALSE);

        or if u want to disabled maximaize and minimize except close use
        stage.initStyle(StageStyle.UTILITY);

        or if you want ot remove all three than use
        stage.initStyle(StageStyle.UNDECORATED);
        
        evita que se pueda redimensionar
        stage.setResizable(false);
        
        pantalla completa
        stage.setMaximized(true);
        
        on top ever
        stage.setAlwaysOnTop(true);
         */

        //yourframe.setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
        stage.setAlwaysOnTop(true);
        stage.initStyle(StageStyle.UNDECORATED);
        stage.setTitle("Hello World!");
        stage.setScene(scene);
        stage.show();
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        launch(args);
    }

}
