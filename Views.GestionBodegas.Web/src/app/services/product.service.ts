import { Injectable } from '@angular/core';
import { HttpClient } from  '@angular/common/http';

import { environment } from '../../environments/environment'
import { ApiResponse } from '../models/apiResponse.model';
import { Observable } from 'rxjs';

const api : string = environment.gestionBodegasApi + 'product';

@Injectable
({
    providedIn: 'root'
})
export class ProductService
{
    constructor(private httpClient : HttpClient) 
    { }

    getAllProducts(warehouseId : number) : Observable<ApiResponse>
    {
        return this.httpClient.get(api + "?warehouseId=" + warehouseId);
    }
}
