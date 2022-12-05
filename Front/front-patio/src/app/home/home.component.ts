import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Area } from '../Areas';
import axios from 'axios';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit{
  constructor(private router: Router) { }

  areas : Array<Area> = [];

  ngOnInit(): void {
    this.initialize();
  }

  async initialize(){
    var config = {
      method: 'get',
      url: 'https://localhost:7170/Alocacao/getAll',
      headers: {},
      data: '',
    }

    var instance = this;
    axios(config)
      .then(function (response) {
        instance.areas = response.data;
        for (let i = 1; i < 12; i++) {
          instance.trocaCor(i);
        }
      })
      .catch(function (error) {
        console.log(error);
      });
  }

  trocaCor(id : number){
    this.areas.forEach(obj => {
      var a = document.getElementById(id.toString()) as HTMLElement;
      if(obj.quantidade > 0 && obj.area.toString() == id.toString()){
        a.style.backgroundColor = "#0000FF";
      }
    })
  };

  entrar(id : number){
    this.areas.forEach(obj => {
      if(obj.quantidade > 0 && obj.area.toString() == id.toString()){
        this.router.navigate(['/area/'+id]);
      }
    })
  };
}
