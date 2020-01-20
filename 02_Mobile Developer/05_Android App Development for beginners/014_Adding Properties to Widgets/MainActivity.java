package com.example.alison;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.RelativeLayout;
import android.widget.Button;
import android.graphics.Color;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        //Layout
        RelativeLayout buckysLayout = new RelativeLayout(this);
        buckysLayout.setBackgroundColor(Color.GREEN);

        RelativeLayout.LayoutParams buttonDetails = RelativeLayout.LayoutParams(
                RelativeLyaout.layoutParams.WRAP_CONTENT,
                RelativeLayout.LayoutParams.WRAP_CONTENT
        );

        buttonDetails.addRule(RelativeLayout.CENTER.HORIZONTAL);
        buttonDetails.addRule(RelativeLayout.CENTER_VERTICAl);

        //Button
        Button redButton = new Button(this);
        redButton.setText("Click me Hoss");
        redButton.setBackgroundColor(Color.RED);

        //Add widget to layout (button is now a child of layout)
        buckysLayout.addView(redButton, buttonDetails);

        //Set this activities content/display to this view
        setContentView(buckysLayout);

    }
}
