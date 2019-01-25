import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
 
void main() => runApp(MaterialApp(
  title:"Poke App", 
  home:HomePage(),
  debugShowCheckedModeBanner: false,
)); 

//stateful hompage
//
class HomePage extends StatefulWidget{
  @override
  HomePageState createState(){
    return new HomePageState();
  }
}
class HomePageState extends State <HomePage>{
  var url = "https://raw.githubusercontent.com/Biuni/PokemonGO-Pokedex/master/pokedex.json";
  @override
  void initState(){
      super.initState();
      fetchdata();
  }
  fetchdata() async{
    var res = http.get(url);

  }

  @override
  Widget build(BuildContext context){
    return Scaffold(
      appBar: AppBar(
        title: Text("Poke App"),
        backgroundColor: Colors.lightGreen,
      ),
        body : Center(child: Text("hello"),
        
        ),
    drawer: Drawer(),
    floatingActionButton: FloatingActionButton(
      onPressed: (){},
      backgroundColor: Colors.lightGreen,
      child: Icon(Icons.refresh),
    ),
    );
  }

}