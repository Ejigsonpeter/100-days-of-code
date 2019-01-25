import 'package:flutter/material.dart';
import 'package:carousel_pro/carousel_pro.dart';

import 'package:shopify/components/horizontal_listview.dart';

void main(){
  runApp(
    MaterialApp(
      debugShowCheckedModeBanner: false,
      home:HomePage(), 
    )
  );
}
class HomePage extends StatefulWidget{
  @override
  _HomePageState createState() => _HomePageState();
  
}

class _HomePageState extends State <HomePage> {
  @override
  Widget build(BuildContext context) {
// image carousel

Widget imgCarousel= new Container(
height: 200.0,
child: new Carousel(
  boxFit: BoxFit.cover,
  images:[
      AssetImage('images/c1.jpg'),
      AssetImage('images/m1.jpeg'),
      AssetImage('images/m2.jpg'),
      AssetImage('images/w1.jpeg'),
      AssetImage('images/w3.jpeg'),
      AssetImage('images/w4.jpeg'),
      new NetworkImage('https://static.independent.co.uk/s3fs-public/thumbnails/image/2019/01/18/13/eden-tote.jpg'),
      new NetworkImage('https://static.independent.co.uk/s3fs-public/thumbnails/image/2019/01/22/11/treya-backpack.jpg'),
      new NetworkImage('https://n3.sdlcdn.com/imgs/c/g/9/Lancer-Sneakers-Multi-Color-Casual-SDL803024449-1-81987.JPG'),
      new NetworkImage('http://www.dhresource.com/260x260s/f2-albu-g2-M00-58-C8-rBVaG1ZvwnmAR-oEAAFPiHzHbgE779.jpg/work-shoes-outdoor-men-039-s-casual-shoes.jpg'),
      
   ],
   autoplay:false,
   animationCurve:Curves.fastOutSlowIn,
   animationDuration: Duration(milliseconds: 100),
   dotSize: 4.0,
   //dotBgColor: Colors.white,
   indicatorBgPadding:4.0 ,



) ,
);




    return Scaffold(
      appBar: new AppBar(
        elevation: 0.1,
        backgroundColor: Colors.red,
        title: Text("Shopify"),
        actions: <Widget>[
          new IconButton(icon: Icon(Icons.search,color:Colors.white,),onPressed:(){}),
          new IconButton(icon: Icon(Icons.shopping_cart,color:Colors.white,),onPressed:(){})
        ],
      ),
      drawer: new Drawer(
        child: new ListView(
          children: <Widget>[
            //  header  
            new UserAccountsDrawerHeader(accountName: Text('Ejigson Peter') ,
            accountEmail:Text('ejigsonpeter@gmail.com'),
            currentAccountPicture: GestureDetector(
              child: new CircleAvatar(
                backgroundColor: Colors.blueGrey,
                child: Icon(Icons.person,color:Colors.white,),
              ),
            ),
            decoration: new BoxDecoration(
              color: Colors.red
            ),
            ),
//                   body
         

          InkWell(
           onTap: (){},
           child: 
         ListTile(
            title: Text("Home Page"),
            leading:Icon(Icons.home,color: Colors.black),
          ),
          ),

          InkWell(
           onTap: (){},
           child: 
         ListTile(
            title: Text("My Account"),
            leading:Icon(Icons.person,color : Colors.blue),
          ),
          ),

          InkWell(
           onTap: (){},
           child: 
         ListTile(
            title: Text("My Orders"),
            leading:Icon(Icons.shopping_basket,color : Colors.cyan),
          ),
          ),

          InkWell(
           onTap: (){},
           child: 
         ListTile(
            title: Text("Categories"),
            leading:Icon(Icons.dashboard,color : Colors.green),
          ),
          ),

          InkWell(
           onTap: (){},
           child: 
         ListTile(
            title: Text("Favorites"),
            leading:Icon(Icons.favorite,color : Colors.red),
          ),
          ),
          Divider(),
          InkWell(
           onTap: (){},
           child: 
         ListTile(
            title: Text("Settings"),
            leading:Icon(Icons.settings,color : Colors.blue),
          ),
          ),

          InkWell(
           onTap: (){},
           child: 
         ListTile(
            title: Text("About"),
            leading:Icon(Icons.help, color:Colors.green),
          ),
          ),


          
          ],
        ),
      ),

      body: new ListView(
        children: <Widget>[
          // image carousel
          imgCarousel,

          //padding widget
          new Padding(padding: const EdgeInsets.all(8.0),
          child: new Text('Categories'),),

          //horizontal list view begin here
          horizontalList(),
        ],
      ),
      );
    
  }

}

