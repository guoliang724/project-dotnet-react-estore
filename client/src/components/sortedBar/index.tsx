import { Dropdown, Pagination } from "antd";
import type { MenuProps } from "antd";
import { DownOutlined } from "@ant-design/icons";

import { useAppSelector, useAppDispatch } from "../../store/slice";
import {
  setProductParams,
  fetchProductsAsync,
} from "../../store/slice/productSlice";
import SearchBar from "../searchDrawer/searchBar";

function SortedBar() {
  const { brands, types, metaData, unSortedProducts } = useAppSelector(
    (state) => state.products
  );
  const dispatch = useAppDispatch();
  const { totalCount, totalPages, currentPage, pageSize } = metaData;

  const totalNumber = unSortedProducts.length;

  const items: MenuProps["items"] = [
    {
      key: "name",
      label: <div>Alphabetical</div>,
    },
    {
      key: "price",
      label: <div>From Lowest to Highest</div>,
    },
    {
      key: "priceDesc",
      label: <div>From Highest to Lowest</div>,
    },
  ];

  const brandItems = ["All", ...brands].map((brand) => ({
    key: brand === "All" ? "" : brand,
    label: <div>{brand}</div>,
  }));

  const typeItems = ["All", ...types].map((type) => ({
    key: type === "All" ? "" : type,
    label: <div>{type}</div>,
  }));

  const handleClickPrice: MenuProps["onClick"] = ({ key }) => {
    dispatch(setProductParams({ orderBy: key }));
    dispatch(fetchProductsAsync());
  };

  const handleClickBrand: MenuProps["onClick"] = ({ key }) => {
    dispatch(setProductParams({ brands: [key] }));
    dispatch(fetchProductsAsync());
  };

  const handleClickType: MenuProps["onClick"] = ({ key }) => {
    dispatch(setProductParams({ types: [key] }));
    dispatch(fetchProductsAsync());
  };

  const handlePageChange = (page: number) => {
    dispatch(
      setProductParams({
        pageNumber: page,
      })
    );
    dispatch(fetchProductsAsync());
  };

  return (
    <div className="flex flex-row justify-start gap-4 font-Assitant mb-4">
      <div>Sorted By</div>
      <Dropdown
        menu={{ items, onClick: handleClickPrice, selectable: true }}
        trigger={["click"]}
      >
        <div className="flex flex-row justify-center items-baseline gap-1">
          <span className="cursor-pointer">Price</span>
          <DownOutlined className="text-[12px]" />
        </div>
      </Dropdown>
      <Dropdown
        menu={{
          items: brandItems,
          onClick: handleClickBrand,
          selectable: true,
        }}
        trigger={["click"]}
      >
        <div className="flex flex-row justify-center items-baseline gap-1">
          <span className="cursor-pointer">Brand</span>
          <DownOutlined className="text-[12px]" />
        </div>
      </Dropdown>
      <Dropdown
        menu={{ items: typeItems, onClick: handleClickType, selectable: true }}
        trigger={["click"]}
      >
        <div className="flex flex-row justify-center items-baseline gap-1">
          <span className="cursor-pointer">Type</span>
          <DownOutlined className="text-[12px]" />
        </div>
      </Dropdown>
      <SearchBar onClose={() => {}} />
      <div className="flex flex-row justify-between items-center gap-4">
        <span>Filterd: {totalCount}</span>
        <span>Total: {totalNumber} </span>
      </div>
      <Pagination
        defaultCurrent={1}
        total={metaData.totalCount}
        showSizeChanger={false}
        current={metaData.currentPage}
        pageSize={metaData.pageSize}
        rootClassName="text-sm"
        align="end"
        onChange={(page) => handlePageChange(page)}
      />
    </div>
  );
}

export default SortedBar;
