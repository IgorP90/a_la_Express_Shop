import {Injectable} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../interfaces/product.interface';

@Injectable()
export class HttpService{


    constructor(private http:HttpClient){}

    public get(url:string):Observable<any>{
        return this.http.get(url)
    }

    public post(url:string, product:Product):Observable<any>{
        return this.http.post(url, product)
    }
}   