   M S B A M L   `   `   `  ????N  JWpfAppAuthInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfAppAuthInterfaceWpfAppAuthInterface  5      '    !WpfAppAuthInterface.TimeTablePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WpfAppAuthInterface     5        N? Title$  TimeTablePage??5	       N? 
Background
 ????? N? FontSize$ 18(?64   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??0.6* ?6   ?? 5      $
??0.6* ?6   ?? 5      $
??0.5* ?6   ?? 5      $
??1.5* ?6   .+?5   
   ? $??0??6    ? ColumnDefinitions 5      ?? 5      ?? 5      .+?5      ?? $&?? Выберите учителя:??6   $??5q?61   $??Center=?6<   ? 5      $??1??6   .+?5      ?? -   5         ??Name$ 
TeacherBox??5      $??125,10,50,10q?6/   5      5      ? 5   
   $??1??6    5      ?? 5      ?? 5      .+?5!      ?? $&?? Выберите предмет:??6   $??5q?61   $??Center=?6<   ? 5"      $??1??6   .+?5#      ?? -   5        $ 
SubjectBox??5#      $??125,10,50,10q?6/   5$      5%      ? 5&   
   $??2??6   .+?5'      ?? -   5         ??Name$ 	AddButton??5'      $??Добавить??6(   $??
600,5,20,5q?6;   5(      ? 5)   
   $??3??6   .+?5*      ?? $??10q?6   5+      5,      5-      