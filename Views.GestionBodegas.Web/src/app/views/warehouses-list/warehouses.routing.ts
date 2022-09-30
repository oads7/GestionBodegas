import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WarehousesListComponent } from './warehouses-list.component';



const routes: Routes = 
[
    {
        path: '',
        component: WarehousesListComponent
    },
];
@NgModule
({
    imports:
    [
        RouterModule.forChild(routes)
    ],
    exports: [ RouterModule ]
})
export class WarehousesListRoutingModule
{}
