import { Component, OnInit } from '@angular/core';
import { HttpService } from 'src/app/services/httpService.service';
import { Product } from 'src/app/interfaces/product.interface';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  product:any = 0;

    ngOnInit(): void {}

    get(){
        HttpService.get('https://localhost:44307/home/1').subscribe((data:any) => this.product(data.price))
    }
 
}
