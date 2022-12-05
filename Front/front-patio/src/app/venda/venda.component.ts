import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import axios from 'axios';
import { Area } from '../Areas';
import { Carros } from '../Carros';
import { Clientes } from '../Clientes';
import { Concessionaria } from '../Concessionaria';

@Component({
  selector: 'app-venda',
  templateUrl: './venda.component.html',
  styleUrls: ['./venda.component.scss']
})
export class VendaComponent {
  constructor(private router: Router, private route: ActivatedRoute) { }
  area = 0
  carro = 0
  concessionaria = 0
  carroNome! : Carros
  frase = ''
  carroId = 0

  clienteEsc = 0
  concessionariaEsc = 0

  concessionarias : Array<Concessionaria> = []
  concessionariasValidas : Array<Concessionaria> = []
  clientes : Array<Clientes> = []
  areas : Array<Area> = []
  temp!: Area;

  ngOnInit(): void {
    const routeParams = this.route.snapshot.paramMap;
    this.area = (Number(routeParams.get('Id')));
    this.carro = (Number(routeParams.get('Idcarro')));
    this.concessionaria = (Number(routeParams.get('Idconcessionaria')));

    console.log(this.area, this.carro, this.concessionaria)
    this.initiliaze()
    this.getCarro(this.carro)
  }

  getCarro(carro : number){
    var config = {
      method: 'get',
      url: 'https://localhost:7170/Automoveis/get/'+carro,
      headers: {},
      data: '',
    }

    var instance = this;
    axios(config)
      .then(function (response) {
        instance.carroNome = response.data;
        instance.frase = instance.carroNome?.modelo
        instance.carroId = instance.carroNome?.id
      })
      .catch(function (error) {
        console.log(error);
      });
  }

  initiliaze() {
    this.getConcessionaria()
    this.getClient()
  }

  getClient(){
    var config = {
      method: 'get',
      url: 'https://localhost:7170/Cliente/getAll',
      headers: {},
      data: '',
    }

    var instance = this;
    axios(config)
      .then(function (response) {
        instance.clientes = response.data;
        console.log(instance.clientes)
      })
      .catch(function (error) {
        console.log(error);
      });
  }

  getConcessionaria(){
    var config = {
      method: 'get',
      url: 'https://localhost:7170/Concessionaria/getAll',
      headers: {},
      data: '',
    }

    var instance = this;
    axios(config)
      .then(function (response) {
        instance.concessionarias = response.data;
        instance.getArea()
      })
      .catch(function (error) {
        console.log(error);
      });
  }

  getArea(){
    var config = {
      method: 'get',
      url: 'https://localhost:7170/Alocacao/get/'+this.area,
      headers: { },
      data : ''
    };
    
    var instance  = this;
    axios(config).then(function (response) {
      instance.areas = response.data;
      instance.areas.forEach(obj => {
        instance.concessionarias.forEach(element => {
          console.log("instance.carroId")
          console.log(instance.carroId)
          if(obj.concessionariaId == element.id && obj.automoveisId == instance.carro){
            instance.concessionariasValidas.push(element)
          }
        });
      })
      console.log(instance.concessionariasValidas)
    })
    .catch(function (error) {
      console.log(error);
    });
  }


  vender(){
    let clienteComp = document.getElementById("cliente") as HTMLSelectElement;
    let conceComp = document.getElementById("concessionaria") as HTMLSelectElement;
    let conceComp2 = conceComp.options[conceComp.selectedIndex];
    
    var config2 = {
      method: 'get',
      url: 'https://localhost:7170/Alocacao/get2/'+this.area+'/'+conceComp2.value+'/'+this.carro,
      headers: { },
      data2 : ''
    };
    var instance = this;
    axios(config2)
      .then(function (response) {
        instance.temp = response.data;
        instance.venda(instance.temp.id)
      })
      .catch(function (error) {
        console.log(error);
      });

    
  }

  venda(areaId : number){
    let clienteComp = document.getElementById("cliente") as HTMLSelectElement;
    let conceComp = document.getElementById("concessionaria") as HTMLSelectElement;
    let conceComp2 = conceComp.options[conceComp.selectedIndex];
    let clienteComp2 = clienteComp.options[clienteComp.selectedIndex];
    

    var data = JSON.stringify({
      "quantidade": 1,
      "total": 1,
      "alocacao": areaId,
      "cliente": clienteComp2.value,
    })

    var config = {
      method: 'post',
      url: 'https://localhost:7170/Vendas/register/'+conceComp2.value,
      headers: { 
        'Content-Type': 'application/json'
      },
      data : data
    };

    axios(config)
    .then(function (response) {
      alert("Registrado com sucesso!");
      
    })
    .catch(function (error) {
      alert("Erro Genérico!");
      console.log(error);
    });
  }

  sair(){
    this.router.navigate(['/']);
  };
}