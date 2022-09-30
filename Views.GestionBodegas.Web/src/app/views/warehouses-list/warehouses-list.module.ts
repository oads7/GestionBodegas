import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WarehousesListComponent } from './warehouses-list.component';
import { WarehousesListRoutingModule } from './warehouses.routing';
import { MatTableModule } from '@angular/material/table';



@NgModule
({
    declarations:
    [
        WarehousesListComponent
    ],
    imports:
    [
        CommonModule,
        WarehousesListRoutingModule,

        MatTableModule
    ]
})
export class WarehousesListModule { }
