import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product.model';
import { ProductService } from 'src/app/services/product.service';


@Component
({
    selector: 'app-products-list',
    templateUrl: './products-list.component.html',
    styleUrls: ['./products-list.component.css']
})
export class ProductsListComponent implements OnInit
{
    dataSource : Product[] = []
    displayedColumns : string[] = 
    [
        'productId',
        'productName',
        'productDescription',
        'state',
        'manufacturingDate',
        'expirationDate',
        'entryDate',
        'releaseDate'
    ];

    constructor(private productService : ProductService) { }

    ngOnInit() : void
    {
        let warehouseId = Number(localStorage.getItem('SelectedWarehouse'));
        if (warehouseId == null) warehouseId = 1;
        else warehouseId++;

        this.productService.getAllProducts(warehouseId).subscribe(response =>
        {
            this.dataSource = response.data as Array<Product>
        });
    }

}