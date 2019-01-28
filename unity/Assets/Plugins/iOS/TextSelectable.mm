#import <UIKit/UIKit.h>

extern UIViewController *UnityGetGLViewController();
extern "C" {
    UITextView *textView;
    
    void make_()
    {
        textView = [[UITextView alloc] initWithFrame:CGRectMake(100, 100, 200, 200)];
        textView.text =@"test test test test test test test testtest test";
        textView.editable = NO;
        
        UIView *view = UnityGetGLViewController().view;
        [view addSubview:textView];
    }
    void setText_(const char *txt)
    {
        textView.text = [[NSString alloc] initWithUTF8String:txt];
    }
}

