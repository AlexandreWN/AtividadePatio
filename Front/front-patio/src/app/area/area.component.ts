import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-area',
  templateUrl: './area.component.html',
  styleUrls: ['./area.component.scss']
})
export class AreaComponent {
  constructor(private router: Router) { }
  sair(){
    this.router.navigate(['/']);
  };
  vender(){
    this.router.navigate(['/venda']);
  };
}
