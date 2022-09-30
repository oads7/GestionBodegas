import { Injectable } from '@angular/core';
import { HttpClient } from  '@angular/common/http';

import { environment } from '../../environments/environment'
import { ApiResponse } from '../models/apiResponse.model';
import { Warehouse } from '../models/warehouse.model';
import { Observable } from 'rxjs';

const api : string = environment.gestionBodegasApi + 'warehouse';

@Injectable
({
    providedIn: 'root'
})
export class WarehouseService
{
    constructor(private httpClient : HttpClient) 
    { }

    getAllWarehouses() : Observable<ApiResponse>
    {
        return this.httpClient.get(api);
    }
}
