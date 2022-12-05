import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import axios from 'axios';
import { Area } from '../Areas';
import { Carros } from '../Carros';

@Component({
  selector: 'app-area',
  templateUrl: './area.component.html',
  styleUrls: ['./area.component.scss']
})
export class AreaComponent implements OnInit{
  constructor(private router: Router, private route: ActivatedRoute) { }

  frase = ''
  id = 0
  area : Array<Area> = [];
  carros : Array<Area> = []

  ngOnInit(): void {
    const routeParams = this.route.snapshot.paramMap;
    this.initiliaze(Number(routeParams.get('areaId')));
  }

  async initiliaze(id : number){
    var config = {
      method: 'get',
      url: 'https://localhost:7170/Alocacao/getAll',
      headers: { },
      data : ''
    };
    
    var instance  = this;
    axios(config).then(function (response) {
      //console.table(response.data);
      instance.area = response.data;
      instance.frase = 'Area ' + id
      instance.id = id
      instance.area.forEach(obj => {
        if(obj.quantidade > 0 && obj.area.toString() == id.toString()){
          instance.carros.push(obj);
        }
      })
      console.log(instance.carros)
    })
    .catch(function (error) {
      console.log(error);
    });

  }

  sair(){
    this.router.navigate(['/']);
  };

  vender(idCarro : number, Idconcessionaria : number){
    this.router.navigate(['/venda/'+this.id+'/'+idCarro+'/'+Idconcessionaria]);
  };
}
