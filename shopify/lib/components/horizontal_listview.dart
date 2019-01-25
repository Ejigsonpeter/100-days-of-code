import 'package:flutter/material.dart';


class horizontalList extends StatelessWidget {
  @override
  Widget build(BuildContext context){
    return  Container(
      height: 80.0,
      child: ListView(
        scrollDirection: Axis.horizontal,
        children: <Widget>[
          Categories(
          image_location: 'images/cats/tshirt.png',
          image_caption: 'Tshirt'
          )
        ],
      ),

    );
  }
}

class Categories extends StatelessWidget{
  final String image_location;
  final String image_caption;

  Categories({
    this.image_caption,
    this.image_location
  });
  @override
  Widget build(BuildContext context){
    return Padding(
      padding: const EdgeInsets.all(2.0),
      child: InkWell( onTap: (){},
      child: Container(
        width: 100.0,
        height: 80.0,
      child: ListTile(
        title: Image.asset(image_location),
        subtitle: Text(image_caption),
      ),
      ),
      ),
    );
    
  }
}
