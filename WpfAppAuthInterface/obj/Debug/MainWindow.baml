   M S B A M L   `   `   `  ????N  JWpfAppAuthInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfAppAuthInterfaceWpfAppAuthInterface  5   	   $    WpfAppAuthInterface.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WpfAppAuthInterface     5   	     ? Title$  Login??5   
   $	??400??6   $	??300??6%   
?????w?.??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??0.5* ?6   ?? 5      $
??1.5* ?6   ?? 5      $
??0.2* ?6   ?? 5      $
??0.6* ?6   .+?5   
   ?? $??Sign in??6   $??Center=?6#   $??Center=?6@   $??24(?6[   ? 5   
   $??1??6    ? ColumnDefinitions 5      ?? 5      ?? 5      .+?5      ?? $??Login??6   $??
55,45,0,30q?6%   $??18(?69   ?? 5      $??1??6   $??Password??6%   $??
45,30,0,45q?65   $??18(?6I   ?? 5      -   5         ??Name$ LoginBox??5      $??1??6(   $??
0,45,30,30q?68    ?? TextAlignment$
 Left=?6L   G? 5      -   5         G?Name$ PswrdBox??5      $??1??6,   $??1??69   $??
0,30,30,45q?6I   ?? 5      -   5        $ 	PswrdBoxx??5      $??1??6)   $??1??66   $??
0,30,30,45q?6F   $y?Hidden=?6Z    5      ?? 5      ?? 5      5       ?? 5!   
   -   5         ??Name$ ShowPswrdBox??5!      $??2??6)   $??Show password??66   $??150,-15,30,0q?6N   $??Right=?6d   6?   ? 5"   
   $??3??6    5#      ?? 5$      ?? 5%      .+?5'      ?? -   5         ??Name$ 	SignUpBtn??5'      $??Sign up??6(   $??25q?6;   6G   ?? 5(      -   5        $ 	SignInBtn??5(      $??Sign in??6(   $??1??6;   $??25q?6K   6W   5)      5*      5+      