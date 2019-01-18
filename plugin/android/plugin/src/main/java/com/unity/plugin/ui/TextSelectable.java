package com.unity.plugin.ui;

import android.view.Gravity;
import android.view.ViewGroup.LayoutParams;
import android.widget.RelativeLayout;
import android.widget.TextView;

import com.unity3d.player.UnityPlayer;

public class TextSelectable {

    private TextView textView;

    public static TextSelectable Make(final int width, final int height, final int left, final int top) {
        final TextSelectable textSelectable = new TextSelectable();

        UnityPlayer.currentActivity.runOnUiThread(new Runnable() {
            public void run() {
                RelativeLayout layout = new RelativeLayout(UnityPlayer.currentActivity);
                UnityPlayer.currentActivity.addContentView(layout, new LayoutParams(LayoutParams.MATCH_PARENT, LayoutParams.MATCH_PARENT));
                layout.setGravity(Gravity.TOP);

                textSelectable.textView = new TextView(UnityPlayer.currentActivity);
                textSelectable.SetTextIsSelectable(true);
                RelativeLayout.LayoutParams params = new RelativeLayout.LayoutParams(width, height);
                params.leftMargin = left;
                params.topMargin = top;
                layout.addView(textSelectable.textView, params);
            }
        });

        return textSelectable;
    }

    public void SetText(String text) {
        this.textView.setText(text);
    }

    public void SetTextIsSelectable(boolean selectable) {
        this.textView.setTextIsSelectable(selectable);
    }
}

