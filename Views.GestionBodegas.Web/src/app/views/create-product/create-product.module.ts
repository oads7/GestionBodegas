import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateProductComponent } from './create-product.component';
import { CreateProductRoutingModule } from './create-product.routing';
import { MatTableModule } from '@angular/material/table';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule
({
    declarations:
    [
        CreateProductComponent
    ],
    imports:
    [
        CommonModule,
        CreateProductRoutingModule,
        MatTableModule,
        MatInputModule,
        MatButtonModule,
        ReactiveFormsModule,
        FormsModule,
    ]
})
export class CreateProductModule { }
