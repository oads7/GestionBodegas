import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsListComponent } from './products-list.component';
import { ProductsListRoutingModule } from './products-list.routing';

import { MatTableModule } from '@angular/material/table';


@NgModule
({
    declarations:
    [
        ProductsListComponent
    ],
    imports:
    [
        CommonModule,
        ProductsListRoutingModule,

        MatTableModule
    ]
})
export class ProductsListModule { }
