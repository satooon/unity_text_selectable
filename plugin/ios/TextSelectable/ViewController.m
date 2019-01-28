//
//  ViewController.m
//  TextSelectable
//
//  Created by yoshinori.sato on 2019/01/25.
//  Copyright © 2019 yoshinori.sato. All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()
@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    
    UITextView *tv = [[UITextView alloc] initWithFrame:CGRectMake(100, 100, 200, 200)];
    tv.text =@"test test test test test test test test";
    tv.editable = NO;
    
    [self.view addSubview:tv];
}

@end
