import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-venda',
  templateUrl: './venda.component.html',
  styleUrls: ['./venda.component.scss']
})
export class VendaComponent {
  constructor(private router: Router) { }
  vender(){
    this.router.navigate(['/area']);
  };
}
