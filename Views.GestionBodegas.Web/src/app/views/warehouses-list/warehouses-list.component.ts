import { Component, OnInit } from '@angular/core';
import { Warehouse } from 'src/app/models/warehouse.model';
import { WarehouseService } from 'src/app/services/warehouse.service';


@Component
({
    selector: 'app-warehouses-list',
    templateUrl: './warehouses-list.component.html',
    styleUrls: ['./warehouses-list.component.css']
})
export class WarehousesListComponent implements OnInit
{    
    dataSource : Warehouse[] = []
    displayedColumns : string[] = 
    [
        'warehouseId',
        'warehouseName',
        'warehouseDescription',
        'capacity'
    ];

    constructor(private warehouseService : WarehouseService) { }

    ngOnInit() : void
    {
        let warehouseId = Number(localStorage.getItem('SelectedWarehouse'));
        if (warehouseId == null) warehouseId = 1;
        else warehouseId++;

        this.warehouseService.getAllWarehouses().subscribe(response =>
        {
            this.dataSource = response.data as Array<Warehouse>
        });
    }

}
