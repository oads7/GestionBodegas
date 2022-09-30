import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product.model';
import { ProductService } from 'src/app/services/product.service';
import { MatTableDataSource } from '@angular/material/table';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component
    ({
    selector: 'app-create-product',
    templateUrl: './create-product.component.html',
    styleUrls: ['./create-product.component.css']
    })
export class CreateProductComponent implements OnInit
{
    newProductForm : FormGroup = new FormGroup
    ({
        productName: new FormControl('', [Validators.required]),
        productDescription: new FormControl('', [Validators.required]),
        
        /*
        warehouseId
        state
        manufacturingDate
        expirationDate
        entryDate
        releaseDate
        */
    });

    

    constructor() { }

    ngOnInit() : void
    { }

}
