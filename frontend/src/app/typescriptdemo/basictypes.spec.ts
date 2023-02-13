describe('Declaring Variables in TypeScript', () => {

    describe('Explicitly Typed Variables', () => {

        it('defining types', () => {
            let myName: String | number;

            myName = "Jeff";

            expect(typeof myName).toEqual("string");

            expect(myName).toEqual("Jeff");

            myName = 1138;
            expect(typeof myName).toEqual("number");


            // expect(typeof myName).toEqual("function");
        });

        it('implicity defined types', () => {

            let age = 53;
            let oldEnough = true;

            let name: string | number = "Jeff";

            name = 'Sue';

            name = 1138;
        })
    });

    describe('custom types', () => {
        it('can use types', () => {
            type thingsWithLettersAndStuff = string;

            let myName: ThingWithLettersAndStuff = 'Bob';

            let beer: Product = {
                sku: 'beerz',
                qty: 6,
                price: 11.99,
                description: 'Stuff to drink'
            }
        });

        it('can use interfaces', () => {

        });

        it('can use classes', () => {

        });
    });
});

type Product = {
    sku: string;
    price: number;
    qty: number;
    description?: string
}

type SummaryProduct = Pick<Product, 'price' | 'description'>;

type SummaryProduct2 = Omit<Product, 'sku'>;

interface Customer {
    name: string;
    creditLimit: number;
}